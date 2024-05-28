create database if not exists db_SamsBurger;
use db_SamsBurger;

drop table if exists Stock cascade;
drop table if exists Stock_Menu cascade;
drop table if exists Menu cascade;
drop table if exists Menu_Pesanan cascade;
drop table if exists Pesanan cascade;
drop table if exists Penjualan_harian cascade;
drop table if exists user_data cascade;
drop view if exists vInvoice cascade;
drop view if exists vPenjualanMenuHarian cascade;
drop view if exists vDataPenjualanHarian cascade;
drop view if exists vBahanProduk cascade;
drop view if exists vCuanProduk cascade;
drop view if exists vexpired_status cascade;

create table user_data(
	email varchar(50) primary key not null,
    pass varchar(20) not null,
    posisi varchar (10) not null
);

insert into user_data values ("alfreddhanss@gmail.com", "123456", "Owner"), ("hi@gmail.com", "123456", "Staff");


create table Stock(
	ID_Stock varchar(6) primary key not null,
    Nama_Stock varchar(25) not null,
    Jumlah_Stock integer not null,
    Harga_Beli integer not null,
    Expired_Date date
);

-- contoh dummy
insert into Stock values ("Tom001", "Tomato", 100, 3300, '2023-12-10');
insert into Stock values ("Let001", "Lettuce", 500, 250, '2024-11-02');
insert into Stock values ("Bre001", "Bread", 250, 200, '2024-12-20'),("Bef001", "Beef", 50, 15000, '2024-10-30'), ("Bef002", "Beef", 30, 15000, '2024-11-01'),
("Bef003", "Beef", 40, 15000, '2024-11-05'),("Bef004", "Beef", 30, 15000, '2024-11-08'),("Bef005", "Beef", 20, 15000, '2024-11-14'), ("Che001", "Cheese", 200, 250, '2024-07-01'),
("Chi001", "Chicken", 50, 7000, '2024-10-10'),("Bef006", "Beef", 35, 15000, '2024-12-18'),("Chi002", "Chicken", 50, 7000, '2024-10-14'),
("Tom002", "Tomato", 50, 100, '2024-10-10'),("Tom003", "Tomato", 40, 100, '2024-10-15'),("Tom004", "Tomato", 28, 150, '2024-10-30'),
("Chi003", "Chicken", 50, 6000, '2024-10-25'),("Oni001", "Onion", 50, 150, '2024-10-02'),("Oni002", "Onion", 40, 150, '2024-10-14'),
("Oni003", "Onion", 30, 150, '2024-10-25'),("Bbq001", "Barbeque", 50, 500, '2024-10-02'),("Bbq002", "Barbeque", 70, 500, '2024-10-17'),
("Let002", "Lettuce", 50, 250, '2024-11-23');

create table Stock_Menu(
	ID_Stock varchar(6) references Stock(ID_Stock),
    ID_Menu varchar(6) references Menu(ID_Menu)
);

-- contoh dummy
insert into Stock_Menu values ("Tom001", "BEFBGR");
insert into Stock_Menu values ("Let001", "BEFBGR");
insert into Stock_Menu values ("Bef001", "BEFBGR"), ("Bre001", "BEFBGR"),("Oni001", "BEFBGR"),("Che001", "BEFBGR"),("Chi001", "CKNBGR"),
("Che001", "CKNBGR"),("Let001", "CKNBGR"),("Tom001", "CKNBGR"),("Bre001", "CKNBGR"),("Bef001", "BBQBEF"),("Bre001", "BBQBEF"),
("Tom001", "BBQBEF"),("Let001", "BBQBEF"),("Bbq001", "BBQBEF"),("Che001", "BBQBEF"),("Chi001", "BBQCKN"),("Tom001", "BBQCKN"),
("Let001", "BBQCKN"),("Che001", "BBQCKN"),("Bre001", "BBQCKN");



create table Menu(
	ID_Menu varchar(6) primary key not null,
    Nama_Menu varchar(25) not null,
    Harga_Menu integer not null,
    Sold_out char(1) not null,
    constraint ch_sold check (Sold_out = 0 or Sold_out = 1)
);

-- contoh dummy
insert into Menu values ("BEFBGR", "OG Beef Burger", 40000, 0);
insert into Menu values ("CKNBGR", "OG Chicken Burger", 30000, 0);
insert into Menu values ("BBQCKN", "BBQ Chicken Burger", 32000, 0), ("BBQBEF", "BBQ Beef Burger", 42000, 0),
("FRENCH", "French Fries", 10000, 0), ("COCOLA", "Coca-cola", 6000, 0),("WATERS", "Aqua", 5000, 0),
("TEHBTL", "Teh Botol", 6000, 0)
 ;

create table Menu_Pesanan(
	ID_Menu varchar(6) references Menu(ID_Menu),
    ID_Pesanan varchar(10) references Pesanan(ID_Pesanan)
);

insert into Menu_Pesanan values ("BEFBGR", "P011223001"); 
insert into Menu_Pesanan values ("CKNBGR", "P021223001");
insert into Menu_Pesanan values ("TEHBTL", "P021223001");
insert into Menu_Pesanan values ("BBQBEF", "P021223002");
insert into Menu_Pesanan values ("CKNBBQ", "P011223002");
insert into Menu_Pesanan values ("COCOLA", "P011223002");
insert into Menu_Pesanan values ("TEHBTL", "P031223001");
insert into Menu_Pesanan values ("WATERS", "P031223001");
insert into Menu_Pesanan values ("FRENCH", "P041223001");
insert into Menu_Pesanan values ("BBQBEF", "P041223002");
insert into Menu_Pesanan values ("BBQCKN", "P031223002");
insert into Menu_Pesanan values ("TEHBTL", "P021223002");


create table Pesanan(
	ID_Pesanan varchar(10) primary key not null,
    ID_Penjualan varchar(7) not null,
    Tanggal_Pesanan timestamp not null,
    Total_Harga integer not null,
    Nama_Cust varchar(25) not null
);

insert into Pesanan values ("P011223001", "P011223", '2023-12-01', 40000, "Natalie");
insert into Pesanan values ("P011223002", "P011223", '2023-12-01', 38000, "Steve");
insert into Pesanan values ("P021223001", "P021223", '2023-12-02', 36000, "Frediana");
insert into Pesanan values ("P021223002", "P021223", '2023-12-02', 48000, "Livy");
insert into Pesanan values ("P031223001", "P031223", '2023-12-03', 11000, "Valel");
insert into Pesanan values ("P031223002", "P031223", '2023-12-03', 32000, "Alfie");
insert into Pesanan values ("P041223001", "P041223", '2023-12-04', 10000, "Carry");
insert into Pesanan values ("P041223002", "P041223", '2023-12-04', 42000, "Benny");

create table Penjualan_harian(
	ID_Penjualan varchar(7) primary key not null,
    Tanggal_Penjualan date not null,
    Total_Pendapatan integer not null
);

insert into Penjualan_harian values ("P011223", '2023-12-01', 78000);
insert into Penjualan_harian values ("P021223", '2023-12-02', 84000);
insert into Penjualan_harian values ("P031223", '2023-12-03', 43000);
insert into Penjualan_harian values ("P041223", '2023-12-04', 52000);

create view vInvoice as
	select p.ID_Pesanan, p.Tanggal_Pesanan, p.Nama_Cust, m.Nama_Menu, count(mp.ID_Menu) as Jumlah, (count(mp.ID_Menu) * m.Harga_Menu) as Harga, p.Total_Harga
    from Pesanan p
    join Menu_Pesanan mp
    on p.ID_Pesanan = mp.ID_Pesanan
    join Menu m
    on m.ID_Menu = mp.ID_Menu
    group by 4;
    
create view vPenjualanMenuHarian as
	select ph.ID_Penjualan, m.Nama_Menu as Nama_Menu, count(Nama_Menu) as Jumlah, ph.Tanggal_Penjualan as Tanggal
    from Penjualan_harian ph
    join Pesanan p
    on ph.ID_Penjualan = p.ID_Penjualan
    join Menu_Pesanan mp
    on mp.ID_Pesanan = p.ID_Pesanan
    right join Menu m
    on m.ID_Menu = mp.ID_Menu
    group by 1, 2;
    
create view vDataPenjualanHarian as
	select ph.ID_Penjualan, ph.Tanggal_Penjualan, count(p.Nama_Cust) as Jumlah_Customer, m.Nama_Menu as Terlaris, ph.Total_Pendapatan
    from Pesanan p
    join Penjualan_harian ph
    on p.ID_Penjualan = ph.ID_Penjualan
    join Menu_Pesanan mp
    on mp.ID_Pesanan = p.ID_Pesanan
    join Menu m
    on m.ID_Menu = mp.ID_Menu
    group by ph.ID_Penjualan, m.Nama_Menu
    having count(m.Nama_Menu) = (select max(x.maximum) from (select (count(m.Nama_Menu)) as maximum 
    from Menu m, Menu_Pesanan mp, Penjualan_harian ph, Pesanan p 
    where p.ID_Penjualan = ph.ID_Penjualan and mp.ID_Pesanan = p.ID_Pesanan and m.ID_Menu = mp.ID_Menu 
    group by m.Nama_Menu) x);
    
create view vBahanProduk as
	select m.Nama_Menu as Nama_Menu, s.Nama_Stock as Nama_Stock
    from Stock s
    join Stock_Menu sm
    on s.ID_Stock = sm.ID_Stock
    join Menu m
    on m.ID_Menu = sm.ID_Menu;
    
create view vCuanProduk as
	select m.Nama_Menu, m.Harga_Menu, sum(s.Harga_Beli) as HPP, (m.Harga_Menu - sum(s.Harga_Beli)) as Cuan
    from Stock s
    join Stock_Menu sm
    on s.ID_Stock = sm.ID_Stock
    join Menu m
    on m.ID_Menu = sm.ID_Menu
    group by 1, 2;
    
create view vExpired_Status as
	select ID_Stock, if(curdate() >= Expired_Date, 'Expired', if(date_sub(now(), interval 7 day), 'Almost expired', 'Not expired')) as status_expired
    from Stock;
    
drop procedure if exists pExpired_by_ID;
delimiter $$
create procedure pExpired_by_ID(in id varchar(6))
begin
	select * from vExpired_Status
    where ID_Stock = id;
end $$
delimiter ;

drop procedure if exists pDeleteStock;
delimiter $$
create procedure pDeleteStock(in remove_stock int, in kode_stock varchar(6))
begin
	update Stock
	set Jumlah_Stock = Jumlah_Stock - remove_stock
	where ID_Stock = kode_stock;
end $$
delimiter ;

drop procedure if exists pAddStock;
delimiter $$
create procedure pAddStock(in add_stock int, in kode_stock varchar(6))
begin
	update Stock
	set Jumlah_Stock = Jumlah_Stock + add_stock
	where ID_Stock = kode_stock;
end $$
delimiter ;


drop function if exists fID_Batch;
delimiter $$
create function fID_Batch(stock_id varchar(6))
returns varchar(6) deterministic
begin
	declare new_id varchar(6);
    declare id_nama varchar(3);
    set id_nama = substr(stock_id, 1, 3);
    
    select CONCAT(id_nama, LPAD(IFNULL(MAX(CONVERT(SUBSTRING(ID_Stock, 4, 3), UNSIGNED)), 0)+1, 3, '0')) INTO new_id
    from Stock
    where ID_Stock like concat(id_nama, '%');
	return new_id;
end $$
delimiter ;

drop function if exists fNewPesanan;
delimiter $$
create function fNewPesanan()
returns varchar(10) deterministic
begin
	declare new_id varchar(10);
    select CONCAT('P', date_format(curdate(), '%d%m%y'), LPAD(IFNULL(MAX(CONVERT(SUBSTRING(ID_Pesanan, 8, 3), UNSIGNED)), 0)+1, 3, '0')) INTO new_id
    from Pesanan
    where substr(ID_Pesanan, 2, 6) = date_format(curdate(), '%d%m%y');
    
    return new_id;
end $$
delimiter ;

drop trigger if exists tNewBatch;
delimiter $$
create trigger tNewBatch
before insert
on Stock
for each row
begin
	declare idstock varchar(6);
    select ID_Stock into idstock
    from Stock
    where Nama_Stock = new.Nama_Stock
    limit 1;
	set new.ID_Stock = fID_Batch(idstock);
end $$
delimiter ;

drop trigger if exists tNewOrder;
delimiter $$
create trigger tNewOrder
before insert
on Pesanan
for each row
begin
	set new.ID_Pesanan = fNewPesanan();
    set new.ID_Penjualan = substr(fNewPesanan(), 1, 7); 
	
    case
    when substr(new.ID_Pesanan, 8, 3) = 001 then
    INSERT INTO Penjualan_harian (ID_Penjualan, Tanggal_Penjualan, Total_Pendapatan) values (new.ID_Penjualan, curdate(), new.Total_Harga);
    else
    update Penjualan_harian
    set Total_Pendapatan = Total_Pendapatan + new.Total_Harga
    where ID_Penjualan = new.ID_Penjualan;
    end case;
end $$
delimiter ;

drop trigger if exists tStock_after_order
delimiter $$
create trigger tStock_after_order
before insert
on menu_pesanan
for each row
begin
	declare id_pesan varchar(10);
    declare namaMenu varchar(20);

	select ID_Pesanan into id_pesan
    from Pesanan
    order by 1 desc
    limit 1;
    
    select Nama_Menu into namaMenu
    from menu
    where ID_Menu = new.ID_Menu;
    
    set new.ID_Pesanan = id_pesan;
    
    update stock s, vbahanproduk vb, (select Nama_Stock, min(Expired_Date) as Exp from Stock group by Nama_Stock) x
    set s.Jumlah_Stock = s.Jumlah_Stock - 1
    where s.Nama_Stock = vb.Nama_Stock and vb.Nama_Menu = namaMenu and s.Jumlah_Stock > 0 and s.Expired_Date = x.Exp and s.Nama_Stock = x.Nama_Stock;
end $$
delimiter ;


