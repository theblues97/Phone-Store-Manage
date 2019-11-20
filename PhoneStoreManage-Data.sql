use master;
go

use PhoneStoreManage;
go

--delete from CauHinh;
delete from SuaChua;
delete from ChitietHoadon;
delete from HoaDon;
delete from DienThoai;
delete from MauDienThoai;
delete from HangDienThoai;
delete from Account;
delete from NhanVien;
delete from HopDong;
delete from KhachHang;
delete from ChucVu;
go


insert into ChucVu values('1',N'Administrator');
insert into ChucVu values('2',N'Quản lý');
insert into ChucVu values('3',N'Nhân viên');

insert into KhachHang values('1',N'Phạm Tuyết Mai',N'Nữ','1992-07-15','0974991913','maipt@gmail.com',N'Thừa Thiên Huế');
insert into KhachHang values('2',N'Bùi Lưu Ly',N'Nữ','1993-01-24','0948463779','lybl@gmail.com',N'Nghệ An');
insert into KhachHang values('3',N'Trần Uy Vũ',N'Nam','1997-10-11','0913090068','vutu@gmail.com',N'Tuyên Quang');
insert into KhachHang values('4',N'Lý Mạnh Quân',N'Nam','1992-05-11','0926913114','quanlm@gmail.com',N'Cần Thơ');
insert into KhachHang values('5',N'Lý Phúc Lâm',N'Nam','1999-06-22','0916686653','lamlp@gmail.com',N'Lào Cai');
insert into KhachHang values('6',N'Đỗ Hữu Bằng',N'Nam','1993-03-24','0969195621','bangdh@gmail.com',N'Lạng Sơn');
insert into KhachHang values('7',N'Phạm Chi Mai',N'Nữ','1997-07-15','0995489855','maipc@gmail.com',N'Ninh Thuận');
insert into KhachHang values('8',N'Võ Đồng Nghi',N'Nữ','1999-11-07','0917175896','nghivd@gmail.com',N'Tuyên Quang');
insert into KhachHang values('9',N'Nguyễn Tiểu Quỳnh',N'Nữ','1992-04-01','0988283397','quynhnt@gmail.com',N'Điện Biên');
insert into KhachHang values('10',N'Nguyễn Doãn Thanh',N'Nam','1992-01-23','0968359889','thanhnd@gmail.com',N'Gia Lai');
insert into KhachHang values('11',N'Trần Văn Sơn',N'Nam','1996-02-05','0930472573','sontv@gmail.com',N'Kiên Giang');
insert into KhachHang values('12',N'Lê Thục Khuê',N'Nữ','1995-06-23','0922339923','khuelt@gmail.com',N'Quảng Bình');
insert into KhachHang values('13',N'Phạm Thị Thư',N'Nữ','1997-05-17','0903458302','thupt@gmail.com',N'Lâm Đồng');
insert into KhachHang values('14',N'Đăng Thị Nguyệt',N'Nữ','1992-03-10','0927346703','nguyetdt@gmail.com',N'Khánh Hòa');
insert into KhachHang values('15',N'Phan Minh Nhật',N'Nam','1992-10-22','0973434201','nhatpm@gmail.com',N'Tuyên Quang');
insert into KhachHang values('16',N'Hoàng Thanh Thảo',N'Nữ','1998-09-17','0976699321','thaoht@gmail.com',N'Cần Thơ');
insert into KhachHang values('17',N'Lê Nguyệt Hà',N'Nữ','1994-03-20','0915277096','haln@gmail.com',N'Sóc Trăng');
insert into KhachHang values('18',N'Hoàng Mai Lan',N'Nữ','1993-12-19','0971556095','lanhm@gmail.com',N'Đồng Tháp');
insert into KhachHang values('19',N'Đặng Bạch Liên',N'Nữ','1993-06-01','0984181728','liendb@gmail.com',N'Quảng Ninh');
insert into KhachHang values('20',N'Phạm Anh Thái',N'Nam','1994-03-30','0909400994','thaipa@gmail.com',N'Hòa Bình');

insert into HopDong values('1',N'Toàn thời gian','2019-11-1','9998-12-31');
insert into HopDong values('2',N'Bán thời gian','2019-03-01','2019-06-01');
insert into HopDong values('3',N'Toàn thời gian','2018-09-01','2023-09-01');
insert into HopDong values('4',N'Toàn thời gian','2019-11-01','2024-11-01');
insert into HopDong values('5',N'Bán thời gian','2019-11-01','2020-02-01');
insert into HopDong values('6',N'Toàn thời gian','2019-10-01','2024-10-01');
insert into HopDong values('7',N'Toàn thời gian','2019-10-01','2024-10-01');
insert into HopDong values('8',N'Toàn thời gian','2018-03-01','2023-03-01');
insert into HopDong values('9',N'Bán thời gian','2019-04-01','2019-07-01');
insert into HopDong values('10',N'Toàn thời gian','2017-07-01','2022-07-01');

insert into NhanVien values('1',N'Administrator',N'Nam','2019-11-11','0793517964','1','khainq97@gmail.com',N'Đắk Lắk','1','1');
insert into NhanVien values('2',N'Bùi Trung Nghĩa',N'Nam','1982-11-22','0998902604','15000000','nghiabt@gmail.com',N'Hải Dương','2','3');
insert into NhanVien values('3',N'Nguyễn Thanh Dương',N'Nữ','1993-07-13','0975633288','6200000','duongnt@gmail.com',N'Quảng Nam','3','2');
insert into NhanVien values('4',N'Hồ Ái Linh',N'Nữ','1994-03-25','0922143033','9000000','linhha@gmail.com',N'Tây Ninh','3','4');
insert into NhanVien values('5',N'Nguyễn Phương Nghi',N'Nữ','1990-08-17','0916366192','6200000','nghinp@gmail.com',N'Hà Giang','3','5');
insert into NhanVien values('6',N'Nguyễn Minh Triết',N'Nam','1995-09-27','0911416353','8400000','trietnm@gmail.com',N'Hồ Chí Minh','3','6');
insert into NhanVien values('7',N'Trần Thành Trung',N'Nam','1987-02-01','0901816968','8200000','trungtt@gmail.com',N'Bắc Cạn','3','7');
insert into NhanVien values('8',N'Đặng Thái Sơn',N'Nam','1985-09-15','0937015631','9200000','sondt@gmail.com',N'Hồ Chí Minh','3','8');
insert into NhanVien values('9',N'Bùi Bích Ngân',N'Nữ','1990-05-18','0924861008','5800000','nganbb@gmail.com',N'Vĩnh Long','3','9');
insert into NhanVien values('10',N'Lê Thành Công',N'Nam','1996-09-02','0923302286','8800000','conglt@gmail.com',N'Cà Mau','3','10');

insert into Account values('Admin','12345678','1');
insert into Account values('Manager1','123456','2');
insert into Account values('Manager2','123456','3');
insert into Account values('Employee1','123456','4');
insert into Account values('Employee2','123456','5');
insert into Account values('Employee3','123456','6');
insert into Account values('Employee4','123456','7');
insert into Account values('Employee5','123456','8');

insert into HangDienThoai values('1','Apple');
insert into HangDienThoai values('2','Samsung');
insert into HangDienThoai values('3','Oppo');
insert into HangDienThoai values('4','Xiami');
insert into HangDienThoai values('5','Huawei');

insert into MauDienThoai values('1','Samsung Galaxy S10','2019-01-01',N'Sạc, Tai nghe, Sách hướng dẫn, Cáp, Ốp lưng',N'Samsung Galaxy S10 là một trong những chiếc smartphone được trông chờ nhiều nhất trong năm 2019 và không phụ sự kỳ vọng của mọi người thì chiếc Galaxy S thứ 10 của Samsung thực sự gây ấn tượng mạnh cho người dùng. Với một chiếc máy cao cấp như Samsung Galaxy S10 thì việc đầu tiên cần có là máy phải sở hữu một vẻ ngoài "lộng lẫy", thu hút mọi ánh nhìn.','2');
insert into MauDienThoai values('2','Samsung Galaxy S10+','2019-01-01',N'Sạc, Tai nghe, Sách hướng dẫn, Cáp, Ốp lưng',N'Samsung Galaxy S10 là một trong những chiếc smartphone được trông chờ nhiều nhất trong năm 2019 và không phụ sự kỳ vọng của mọi người thì chiếc Galaxy S thứ 10 của Samsung thực sự gây ấn tượng mạnh cho người dùng. Với một chiếc máy cao cấp như Samsung Galaxy S10 thì việc đầu tiên cần có là máy phải sở hữu một vẻ ngoài "lộng lẫy", thu hút mọi ánh nhìn.','2');
insert into MauDienThoai values('3','Samsung Galaxy Note 10','2019-01-01',N'Sạc, Tai nghe, Sách hướng dẫn, Cáp, Ốp lưng',N'Nếu như từ trước tới nay dòng Galaxy Note của Samsung thường ít được các bạn nữ sử dụng bởi kích thước màn hình khá lớn khiến việc cầm nắm trở nên khó khăn thì Samsung Galaxy Note 10 sẽ là chiếc smartphone nhỏ gọn, phù hợp với cả những bạn có bàn tay nhỏ.','2');
insert into MauDienThoai values('4','iPhone Xs Max 64GB','2019-01-01',N'Sạc, Tai nghe, Sách hướng dẫn, Cáp, Ốp lưng',N'Hoàn toàn xứng đáng với những gì được mong chờ, phiên bản cao cấp nhất iPhone Xs Max 64 GB của Apple năm nay nổi bật với chip A12 Bionic mạnh mẽ, màn hình rộng đến 6.5 inch, cùng camera kép trí tuệ nhân tạo và Face ID được nâng cấp.','1');
insert into MauDienThoai values('5','iPhone 11 Pro 256GB','2019-01-01',N'Sạc, Tai nghe, Sách hướng dẫn, Cáp, Ốp lưng',N'iPhone 11 Pro 256GB có lẽ sẽ là chiếc iPhone được nhiều người dùng lựa chọn khi nó sở hữu mức giá tốt hơn chiếc iPhone 11 Pro Max nhưng vẫn sở hữu tất cả những ưu điểm trên người anh em của mình.','1');
insert into MauDienThoai values('6','iPhone 11 Pro Max 256GB','2019-01-01',N'Sạc, Tai nghe, Sách hướng dẫn, Cáp, Ốp lưng',N'iPhone 11 Pro Max 256GB là chiếc iPhone cao cấp nhất trong bộ 3 iPhone Apple giới thiệu trong năm 2019 và quả thực chiếc smartphone này mang trong mình nhiều trang bị xứng đáng với tên gọi "Pro".','1');
insert into MauDienThoai values('7','OPPO F11 Pro 128GB','2019-01-01',N'Sạc, Tai nghe, Sách hướng dẫn, Cáp, Ốp lưng',N'Lâu nay, những chiếc điện thoại của OPPO thường được đánh giá cao ở camera selfie và với OPPO F11 Pro 128GB thì ngoài thế mạnh về camera trước với hệ thống trượt, OPPO làm người ta phải ấn tượng thêm cả về camera sau.','3');
insert into MauDienThoai values('8','OPPO Reno2','2019-01-01',N'Sạc, Tai nghe, Sách hướng dẫn, Cáp, Ốp lưng',N'Sau sự thành công của chiếc OPPO Reno với thiết kế mới lạ, camera chất lượng thì mới đây OPPO tiếp tục giới thiệu phiên bản nâng cấp của chiếc smartphone này là chiếc OPPO Reno2.','3');
insert into MauDienThoai values('9','OPPO Reno 10x Zoom Edition','2019-01-01',N'Sạc, Tai nghe, Sách hướng dẫn, Cáp, Ốp lưng',N'Những chiếc flagship trong năm 2019 không chỉ có một camera chụp ảnh đẹp, chụp xóa phông ảo diệu mà còn phải "chụp thật xa" và với chiếc OPPO Reno 10x Zoom Edition chính thức gia nhập thị trường "smartphone có camera siêu zoom".','3');
insert into MauDienThoai values('10','Xiaomi Redmi Note 8 (4GB/64GB)','2019-01-01',N'Sạc, Tai nghe, Sách hướng dẫn, Cáp, Ốp lưng',N'Xiaomi Redmi Note 8 4GB/64GB là chiếc smartphone tầm trung mới nhất của Xiaomi, chiếc máy này gây ấn tượng với cấu hình phần cứng mạnh mẽ, hệ thống 4 camera sau chất lượng và đi kèm giá bán cực kỳ hấp dẫn.','4');
insert into MauDienThoai values('11','Xiaomi Mi 9T','2019-01-01',N'Sạc, Tai nghe, Sách hướng dẫn, Cáp, Ốp lưng',N'Xiaomi Mi 9T (tên khác là Redmi K20) là chiếc smartphone vừa được giới thiệu gây rất nhiều chú ý với người dùng bởi nó hội tụ đủ 3 yếu tố "ngon bổ rẻ".','4');
insert into MauDienThoai values('12','Xiaomi Redmi 7A (2GB/32GB)','2019-01-01',N'Sạc, Tai nghe, Sách hướng dẫn, Cáp, Ốp lưng',N'Xiaomi Redmi 7A 2GB/32GB  là một chiếc smartphone theo phong cách truyền thống của Xiaomi, mang tới người dùng trải nghiệm Android ổn trên một chiếc máy có mức giá rất hấp dẫn.','4');
insert into MauDienThoai values('13','Huawei P30 Pro','2019-01-01',N'Sạc, Tai nghe, Sách hướng dẫn, Cáp, Ốp lưng',N'Huawei P30 Pro là một bước đột phá của Huawei cũng như camera trên smartphone khi đem lại khả năng zoom như một "kính viễn vọng".','5');
insert into MauDienThoai values('14','Huawei Y9 Prime(2019)','2019-01-01',N'Sạc, Tai nghe, Sách hướng dẫn, Cáp, Ốp lưng',N'Huawei Y9 Prime (2019) là phiên bản kế nhiệm của chiếc Y9 Prime (2018) đã ra mắt năm ngoái và cũng là chiếc điện thoại đầu tiên của Huawei được trang bị công nghệ camera trượt và màn hình tràn viền ra bốn cạnh.','5');
insert into MauDienThoai values('15','Huawei Nova 3i','2019-01-01',N'Sạc, Tai nghe, Sách hướng dẫn, Cáp, Ốp lưng',N'Với những smartphone như Nova 2i hay Nova 3e thì Huawei đã và đang tạo nên những cơn sốt rất lớn trong phân khúc tầm trung và cái tên mới Huawei Nova 3i được cải tiến và nâng cấp nhiều điểm mới, hứa hẹn sẽ mang lại làn gió mới cho thị trường.','5');

insert into DienThoai values('1',N'Đen','10','21990000','1');
insert into DienThoai values('2',N'Trắng','10','20990000','1');
insert into DienThoai values('3',N'Đen','10','21990000','2');
insert into DienThoai values('4',N'Trắng','10','20990000','2');
insert into DienThoai values('5',N'Đen','10','21990000','3');
insert into DienThoai values('6',N'Trắng','10','20990000','3');
insert into DienThoai values('7',N'Đen','10','27990000','4');
insert into DienThoai values('8',N'Trắng','10','27990000','4');
insert into DienThoai values('9',N'Đen','10','34990000','5');
insert into DienThoai values('10',N'Trắng','10','34990000','5');
insert into DienThoai values('11',N'Đen','10','37990000','6');
insert into DienThoai values('12',N'Trắng','10','37990000','6');
insert into DienThoai values('13',N'Đen','10','7990000','7');
insert into DienThoai values('14',N'Trắng','10','7490000','7');
insert into DienThoai values('15',N'Đen','10','14990000','8');
insert into DienThoai values('16',N'Trắng','10','14990000','8');
insert into DienThoai values('17',N'Đen','10','16990000','9');
insert into DienThoai values('18',N'Trắng','10','16990000','9');
insert into DienThoai values('19',N'Đen','10','4990000','10');
insert into DienThoai values('20',N'Trắng','10','4990000','10');
insert into DienThoai values('21',N'Đen','10','7990000','11');
insert into DienThoai values('22',N'Trắng','10','7990000','11');
insert into DienThoai values('23',N'Đen','10','2190000','12');
insert into DienThoai values('24',N'Trắng','10','2190000','12');
insert into DienThoai values('25',N'Đen','10','21690000','13');
insert into DienThoai values('26',N'Trắng','10','20690000','13');
insert into DienThoai values('27',N'Đen','10','5490000','14');
insert into DienThoai values('28',N'Trắng','10','5490000','14');
insert into DienThoai values('29',N'Đen','10','5390000','15');
insert into DienThoai values('30',N'Trắng','10','5390000','15');

--insert into CauHinh values('1','2K+ (1440 x 3040 Pixels)','6.1"',N'Chính 12 MP & Phụ 12 MP, 16 MP',N'Exynos 9820 2 nhân 2.7 GHz, 2 nhân 2.3 GHz và 4 nhân 1.9 GHz','8 GB','128 GB','Li-ion 3400 mAh');
--insert into CauHinh values('2','2K+ (1440 x 3040 Pixels)','6.4"',N'Chính 12 MP & Phụ 12 MP, 16 MP',N'Exynos 9820 2 nhân 2.7 GHz, 2 nhân 2.3 GHz và 4 nhân 1.9 GHz','8 GB','128 GB','Li-ion 4100 mAh');
--insert into CauHinh values('3','Full HD+ (1080 x 2280 Pixels)','6.3"',N'Chính 12 MP & Phụ 12 MP, 16 MP',N'Exynos 9825 2 nhân 2.73 GHz, 2 nhân 2.4 GHz & 4 nhân 1.9 GHz','8 GB','256 GB','Li-ion 3500 mAh');
--insert into CauHinh values('4','1242 x 2688 Pixels','6.5"',N'Chính 12 MP & Phụ 12 MP',N'Apple A12 Bionic 2 nhân 2.5 GHz Vortex & 4 nhân 1.6 GHz Tempest','4 GB','64 GB','Li-ion 3174 mAh');
--insert into CauHinh values('5','1125 x 2436 Pixels','5.8"',N'3 Camera 12 MP',N'Apple A13 Bionic 6 nhân','4 GB','256 GB','Li-ion 3046mAh');
--insert into CauHinh values('6','1242 x 2688 Pixels','6.5"',N'3 Camera 12 MP',N'Apple A13 Bionic 6 nhân','4 GB','256 GB','Li-ion 3969 mAh');
--insert into CauHinh values('7','Full HD+ (1080 x 2340 Pixels)','6.5"',N'Chính 48 MP & Phụ 5 MP',N'MediaTek Helio P70 4 nhân 2.1 GHz Cortex-A73 & 4 nhân 2.0 GHz Cortex-A53','6 GB','128 GB','Li-ion 4000 mAh');
--insert into CauHinh values('8','Full HD+ (1080 x 2400 Pixels)','6.55"',N'Chính 48 MP & Phụ 13 MP, 8 MP, 2 MP',N'Snapdragon 730G 2 nhân 2.2 Ghz & 6 nhân 1.8 Ghz','8 GB','256 GB','Li-ion 4000 mAh');
--insert into CauHinh values('9','Full HD+ (1080 x 2340 Pixels)','6.6"',N'Chính 48 MP & Phụ 13 MP, 8 MP',N'Snapdragon 855 1 nhân 2.84 GHz, 3 nhân 2.42 GHz & 4 nhân 1.8 GHz','8 GB','	256 GB','Li-ion 4065 mAh');
--insert into CauHinh values('10','Full HD+ (1080 x 2340 Pixels)','6.3"',N'Chính 48 MP & Phụ 8 MP, 2 MP, 2 MP',N'Qualcomm Snapdragon 665 4 nhân 2.0 GHz và 4 nhân 1.8 GHz','4 GB','64 GB','Li-ion 4000 mAh');
--insert into CauHinh values('11','Full HD+ (1080 x 2340 Pixels)','6.39"',N'Chính 48 MP & Phụ 13 MP, 8 MP',N'Snapdragon 730 2 nhân 2.2 Ghz & 6 nhân 1.8 Ghz','6 GB','64 GB','Li-ion 4000 mAh');
--insert into CauHinh values('12','HD+ (720 x 1440 Pixels)','5.45"',N'12 MP',N'Qualcomm Snapdragon 439 8 nhân 1.95 Ghz','2 GB','32 GB','Li-ion 4000 mAh');
--insert into CauHinh values('13','Full HD+ (1080 x 2340 Pixels)','6.47"',N'Chính 40 MP & Phụ 20 MP, 8 MP, TOF 3D',N'Hisilicon Kirin 980 2 nhân 2.6 GHz Cortex A76 & 2 nhân 1.92 GHz Cortex A76 & 4 nhân 1.8 GHz Cortex A55','8 GB','256 GB','Li-ion 4200 mAh');
--insert into CauHinh values('14','Full HD+ (1080 x 2340 Pixels)','6.59"',N'Chính 16 MP & Phụ 8 MP, 2 MP',N'HiSilicon Kirin 710F 4 nhân 2.2 GHz Cortex-A73 & 4 nhân 1.7 GHz Cortex-A53','4 GB','128 GB','Li-ion 4000 mAh');
--insert into CauHinh values('15','Full HD+ (1080 x 2340 Pixels)','6.3"',N'Chính 16 MP & Phụ 2 MP',N'HiSilicon Kirin 710 4 nhân 2.2 GHz Cortex-A73 & 4 nhân 1.7 GHz Cortex-A53','4 GB','128 GB','Li-ion 3340 mAh');

insert into HoaDon values('1','1','3','2019-02-27','2019-08-27',N'Mua tại cửa hàng',N'Thanh toán trực tiếp','0');
insert into HoaDon values('2','4','4','2019-02-28','2019-02-28',N'Mua tại của hàng',N'Thanh toán bằng thẻ','0');
insert into HoaDon values('3','5','3','2019-03-02','2019-09-02',N'Giao hàng tại nhà',N'Thanh toán bằng thẻ','0');
insert into HoaDon values('4','11','5','2019-04-11','2019-06-11',N'Mua tại cửa hàng',N'Thanh toán trực tiếp','0');
insert into HoaDon values('5','12','5','2019-02-13','2019-02-13',N'Mua tại cửa hàng',N'Thanh toán bằng thẻ','0');
insert into HoaDon values('6','9','6','2019-05-24','2019-05-24',N'Mua tại cửa hàng',N'Thanh toán trực tiếp','0');

insert into ChiTietHoadon values('1','1','2');
insert into ChiTietHoadon values('2','1','29');
insert into ChiTietHoadon values('3','2','4');
insert into ChiTietHoadon values('4','3','1');
insert into ChiTietHoadon values('5','4','21');
insert into ChiTietHoadon values('6','5','16');
insert into ChiTietHoadon values('7','6','28');
go

exec pro_CreateWarrantys 1, 'Huawei Nova 3i', '2019-10-15', '0', N'Thanh toán trực tiếp', N'Thay màn hình', '','','2';
exec pro_CreateWarrantys 2, 'Samsung Galaxy S10+', '2019-10-15', '13000000', N'Thanh toán trực tiếp', N'Thay màn hình', '10','9',null;