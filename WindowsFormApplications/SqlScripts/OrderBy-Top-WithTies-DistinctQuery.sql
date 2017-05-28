-- order by, top, with ties, distinct

-- order by kolonadi; secilen kolona göe verileri küçükten büyüğe(ascending) (A-Z) doğru sıralar.

-- Eğer verilen büyükten küçüğe (Z-A) sıralanmasını istersek desc komutunu eklemeliyiz.

-- Müşterileri isimlerine göre alfabetik olarak listeleyen sorgu
select * from Musteriler order by MusteriAd

-- Satış bilgilerini satış adetlerine göre büyükten küçüğe listeleyen sorgu
select * from FilmSatis order by Adet desc

-- Satış bilgilerini satış tutarlarına göre büyükten küçüğe listeleyen sorgu
select MusteriNo, Adet, BirimFiyat, Adet * BirimFiyat as Tutar from FilmSatis order by Tutar desc

-- Bir defada yapılan en yüksek alışveriş tutarı
select max(Adet * BirimFiyat) as EnYuksekAlısveris from FilmSatis

-- Bir defada yapılan en yüksek alışveriş tutarı müşteri numarası ile gösteren sorgu
select MusteriNo, max(Adet * BirimFiyat) as EnYuksekAlisveris from FilmSatis group by MusteriNo

-- Top n: Sonuc listesinin üstten istediğimiz kadar satırını görüntüler
select top 1 MusteriNo, Adet * BirimFiyat as EnYuksekAlisveris from FilmSatis order by EnYuksekAlisveris desc

select top 1 MusteriNo, max(Adet * BirimFiyat) as EnYuksekAlisveris from FilmSatis group by MusteriNo order by EnYuksekAlisveris desc

-- Bir defada yapılan en yüksek alışveriş tutarını satış detaylarıyla gösteren sorgu
select top 1 Tarih, MusteriNo, FilmNo, Adet, BirimFiyat, Adet * BirimFiyat as EnYuksekAlisveris from FilmSatis order by EnYuksekAlisveris desc

select top 1 Tarih, MusteriAd + ' ' +  MusteriSoyad as Musteri, FilmNo, Adet, BirimFiyat, Adet * BirimFiyat as EnYuksekAlisveris from FilmSatis fs inner join  order by EnYuksekAlisveris desc

-- Kampanya: Tek seferde en yüksek alışverişi yapan 2 müşterimize araba hediye ediyoruz.
select top 2 with ties MusteriAd + ' ' + MusteriSoyad as Musteri, Adet, BirimFiyat, Adet * BirimFiyat as Tutar from FilmSatis fs inner join Musteriler m on fs.MusteriNo = m.MusteriNo order by Tutar desc

-- with ties: Sıralama yapılan değerde kırılma oluncaya kadar listelemeye devam eder(top sayısına bakmadan).
 
-- distinct: Benzer kayıtlardan sadece birini dikkate alır.
select * from FilmSatis

--Bugüne kadar kaç farklı müşterininin alışveriş yaptığını gösteren sorgu
select count(distinct(MusteriNo)) as FarklıMusteri from FilmSatis 

-- VideoMarket te satışı devam eden kaç farklı türde film olduğunu gösteren sorgu
select count(distinct FilmTurNo) as FarklıTurdeFilm from Filmler where Varmi = 1