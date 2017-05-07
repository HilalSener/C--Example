use master
go
create database VideoMarket
go
use VideoMarket 
go
create table FilmTurleri
(
FilmTurNo int primary key identity(1,1),
TurAd varchar(20) not null,
Aciklama varchar(150)
)
go
create table Filmler
(
	FilmNo int primary key identity(1,1),
	FilmAd varchar(50) not null,
	FilmTurNo int not null,
	Yonetmen varchar(100) not null,
	Oyuncular varchar(max) not null,
	Ozet varchar(max),
	Fiyat money not null default 0,
	Varmi bit not null default 1
)
go
create table Musteriler
(
	MusteriNo int primary key identity(1,1),
	MusteriAd varchar(20) not null,
	MusteriSoyad varchar(20) not null,
	Telefon varchar(20),
	Adres varchar(150)
)
go
create table FilmSatis
(
	SatisNo int primary key identity(1,1),
	Tarih datetime not null default getdate(),
	FilmNo int not null,
	MusteriNo int not null,
	Adet int not null default 1,
	BirimFiyat money not null default 0
)
go
insert into FilmTurleri(TurAd, Aciklama) values('Komedi', 'çok komik')
insert into FilmTurleri(TurAd, Aciklama) values('Romantik Komedi', 'hem romantik hem komik')
insert into FilmTurleri(TurAd, Aciklama) values('Savaş', 'tarih, kan ve gözyaşı')
insert into FilmTurleri(TurAd, Aciklama) values('Dram', 'hüzün dolu sahneler')
insert into FilmTurleri(TurAd, Aciklama) values('Bilim Kurgu', 'fantastik')
insert into FilmTurleri(TurAd, Aciklama) values('Aþk', 'çok sıkıcı')
insert into FilmTurleri(TurAd, Aciklama) values('Animasyon', 'çizgi film')
insert into FilmTurleri(TurAd, Aciklama) values('Korku-Gerilim', 'çok korkunç')
insert into FilmTurleri(TurAd, Aciklama) values('Aksiyon', 'çok hareketli, tehlikeli sahneler')
insert into FilmTurleri values('Biyografi', 'Hayat hikayesi')

insert into Filmler(FilmAd, FilmTurNo, Yonetmen, Oyuncular) values('Gladyator',3, 'Ridley Scot', 'Russel Crove')
insert into Filmler(FilmAd, FilmTurNo, Yonetmen, Oyuncular) values('Recep İvedik',1, 'Togay Gökbakar', 'Şahan Gökbakar')
insert into Filmler(FilmAd, FilmTurNo, Yonetmen, Oyuncular) values('Benjamin Button',5, 'David Fincher', 'Brad Pitt')
insert into Filmler(FilmAd, FilmTurNo, Yonetmen, Oyuncular) values('Yıldızlar Arası',5, 'Christopher Nolan', 'Anne Hateway')
insert into Filmler(FilmAd, FilmTurNo, Yonetmen, Oyuncular) values('Terminal',10, 'Steven Spielberg', 'Tom Hanks')
insert into Filmler(FilmAd, FilmTurNo, Yonetmen, Oyuncular) values('Yüzüklerin Efendisi',5, 'Peter Jackson', 'Orlando Bloom')
insert into Filmler(FilmAd, FilmTurNo, Yonetmen, Oyuncular) values('Truva',3, 'Wolfgan Pettersen', 'Orlando Bloom, Brad Pitt')
insert into Filmler(FilmAd, FilmTurNo, Yonetmen, Oyuncular) values('Son Umut',3, 'Russel Crove', 'Russel Crove, Cem Yýlmaz')
insert into Filmler(FilmAd, FilmTurNo, Yonetmen, Oyuncular) values('Gora',1, 'Ömer Faruk Sorak', 'Cem Yýlmaz')
insert into Filmler(FilmAd, FilmTurNo, Yonetmen, Oyuncular) values('Fight Club',9, 'David Fincher', 'Brad Pitt')
insert into Filmler(FilmAd, FilmTurNo, Yonetmen, Oyuncular) values('Noting Hill',2, 'Robert Mitchell', 'Hugh Grant, Julia Roberts')
insert into Filmler(FilmAd, FilmTurNo, Yonetmen, Oyuncular) values('Buz Devri',7, 'Mike Tarmier', 'Ray Romanov, Dennis Leary')

insert into Musteriler (MusteriAd, MusteriSoyad, Telefon, Adres) values('Ali','Uçar','2125345344','Sefaköy-İstanbul')
insert into Musteriler (MusteriAd, MusteriSoyad, Telefon, Adres) values('Neşe','Koşar','2163345344','Kadýköy-İstanbul')
insert into Musteriler (MusteriAd, MusteriSoyad, Telefon, Adres) values('Vedat','Kaya','2122343411','Þiþli-İstanbul')
insert into Musteriler (MusteriAd, MusteriSoyad, Telefon, Adres) values('Oya','Sever','2163111344','Ümraniye-İstanbul')
insert into Musteriler (MusteriAd, MusteriSoyad, Telefon, Adres) values('Ayşe','Coþar','2125345897','Ataköy-İstanbul')

update Filmler set Ozet='heyecan, aksiyon, gerilim' where FilmTurNo = 9
delete from Musteriler where MusteriNo = 5

insert into Musteriler (MusteriAd, MusteriSoyad, Telefon, Adres) values('Ayşe','Coşar','2125345897','Ataköy-İstanbul')


insert into FilmSatis(FilmNo, MusteriNo, Adet, BirimFiyat) values(2,1,3,22)
insert into FilmSatis(FilmNo, MusteriNo, Adet, BirimFiyat) values(3,2,1,25)
insert into FilmSatis(FilmNo, MusteriNo, Adet, BirimFiyat) values(5,1,2,24)
insert into FilmSatis(FilmNo, MusteriNo, Adet, BirimFiyat) values(8,4,5,21)
insert into FilmSatis(FilmNo, MusteriNo, Adet, BirimFiyat) values(9,3,3,23)
insert into FilmSatis(FilmNo, MusteriNo, Adet, BirimFiyat) values(11,2,6,20)
insert into FilmSatis(FilmNo, MusteriNo, Adet, BirimFiyat) values(3,1,4,21)
insert into FilmSatis(FilmNo, MusteriNo, Adet, BirimFiyat) values(8,3,3,22)
insert into FilmSatis(FilmNo, MusteriNo, Adet, BirimFiyat) values(12,1,1,26)
insert into FilmSatis(FilmNo, MusteriNo, Adet, BirimFiyat) values(4,4,5,20)
insert into FilmSatis(FilmNo, MusteriNo, Adet, BirimFiyat) values(11,6,2,23)

alter table Filmler
add constraint FK_Filmler_FilmTurleri
foreign key(FilmTurNo)
references FilmTurleri(FilmTurNo)

alter table FilmSatis
add constraint FK_FilmSatis_Filmler
foreign key(FilmNo)
references Filmler(FilmNo)

alter table FilmSatis
add constraint FK_FilmSatis_Musteriler
foreign key(MusteriNo)
references Musteriler(MusteriNo)

alter table Filmler
add Miktar int not null default 10

alter table FilmTurleri
add Silindi bit not null default 0

alter table Musteriler
add Silindi bit not null default 0

alter table FilmSatis
add Silindi bit not null default 0