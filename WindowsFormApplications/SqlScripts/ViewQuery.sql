-- View Dosyaları

-- Sadece sorgulardan oluşan sanal dosyalardır. 
-- Normalleştirme onucu oluşan çok sayıda tablodan istenilen kolonların çekilmesiyle hazırlanacak sorular bir view dosyası olarak kayıt edilir. İstenildiğinde bu dosya çağrılır.

-- Bu dosyalara hesaplanmış kolonlar ilave edilir.

-- Yetki sınırlaması(Güvenlik)

-- View dosyaları çağrıldığında, bilgiler gerçek verilerden çekilir.

select * from vw_FilmlerTurler

sp_helptext vw_FilmlerTurler  -- Dosyanın içeriğini(kod) gösterir.
  
sp_depends vw_FilmlerTurler  -- View sorgusundan etkilenen tablo ve kolonları listeler

create view vw_MusteriRehber
as
select MusteriAd + ' ' + MusteriSoyad as Musteri, Telefon from Musteriler where Silindi = 0

select * from vw_MusteriRehber

alter view vw_MusteriRehber
with encryption -- Şifreleyerek kodların görünmesini engeller
as
select MusteriAd + ' ' + MusteriSoyad as Musteri, Telefon from Musteriler where Silindi = 0

sp_helptext vw_MusteriRehber

--Encryption olmadan çalıştırılırsa şifre kalkar
alter view vw_MusteriRehber
as
select MusteriAd + ' ' + MusteriSoyad as Musteri, Telefon from Musteriler where Silindi = 0

sp_helptext vw_DetayliFilmSatis

-- View' larda kayıt ekleme, değiştirme, silme
-- Bu işlemler sadece 1 tabloyu etkilemelidir
--Herhangi bir kısıtlamaya takılmamalıdır (not null, constraints)

insert into vw_DetayliFilmSatis(TurAd) values('Yeni Tür')

select * from FilmTurleri
