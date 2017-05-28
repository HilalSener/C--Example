--- Tarih İşlemleri

use VideoMarket
go
select * from FilmSatis where Tarih='29.05.2017' --Tatih kolonu DateTime, sağ taraftaki ifade VarChar olduğundan hata veriyor.
select getdate()
select * from FilmSatis where Tarih=getdate()

select Convert(varchar(20), getdate(), 101) --mm/dd/yyyy
select Convert(varchar(20), getdate(), 102) --yyyy.mm.dd
select Convert(varchar(20), getdate(), 103) --dd/mm/yyyy
select Convert(varchar(20), getdate(), 104) --dd.mm.yyyy
select Convert(varchar(20), getdate(), 105) --dd-mm-yyyy
select Convert(varchar(20), getdate(), 106) --dd MM yyyy
select Convert(varchar(20), getdate(), 107) --MMM dd.yyyy
select Convert(varchar(20), getdate(), 108) --hh:mm:ss
select Convert(varchar(20), getdate(), 109) --dd mm yyyy h:mm:s
select Convert(varchar(20), getdate(), 110) --mm-dd-yyyy

select * from FilmSatis where Convert(varchar(20), Tarih, 104) = '29.05.2017'

--Günlük(Bulunduğumuz gün) satış bilgilerini listeleyen sorgu
 select * from FilmSatis where Convert(varchar(20), Tarih, 104) = Convert(varchar(20), getdate(), 104)

 --Nisan 2017 tarihindeki satışları listeleyen sorgu
 select * from FilmSatis where Convert(varchar(20), Tarih, 104) >=  '01.04.2017' and Convert(varchar(20), Tarih, 104) <= '31.04.2017' --Tarih kolonundaki değerler varchar' a dönüştürüldüğünden karşılaştırma soldan karakter karakter yapılıyor

 --Eğer tarihleri yyyy.mm.dd formatına çevirirsek, varchar olmasına rağmen doğru çalışacaktır.
 select * from FilmSatis where Convert(varchar(20), Tarih, 102) >= '2017.04.01' and Convert(varchar(20), Tarih, 102) <= '2017.04.30'

 select * from FilmSatis where Convert(date, Tarih, 104) >= Convert(date, '01.04.2017', 104) and Convert(date, Tarih, 104) <= Convert(date, '30.04.2017', 104)

 --between and yapısı
 select * from FilmSatis where Silindi=0 and Convert(date, Tarih, 104) between Convert(date, '01.04.2017', 104) and Convert(date, '30.04.2017', 104) 

 --Bugünkü satışların toplam değeri(hasılat) ne kadardır. 
 select sum(Adet*BirimFiyat) as Hasılat from FilmSatis where Convert(date, Tarih, 104) = Convert(date, getdate(), 104)

