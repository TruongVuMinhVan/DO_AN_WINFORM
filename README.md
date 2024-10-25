CHẠY SQL: 

Cho nhập dữ liệu các bảng:

INSERT INTO KHACH_HANG (kh_id, kh_ten, kh_gioitinh, kh_sdt)
VALUES 
    ('KH001', 'Nguyen Van A', 'Nam', '0901234567'),
    ('KH002', 'Tran Thi B', 'Nu', '0912345678'),
    ('KH003', 'Le Thi C', 'Nu', '0923456789'),
    ('KH004', 'Hoang Van D', 'Nam', '0934567890'),
    ('KH005', 'Bui Thi E', 'Nu', '0945678901'),
    ('KH006', 'Phan Van F', 'Nam', '0956789012');


INSERT INTO NHAN_VIEN (nv_id, nv_ten, nv_sdt, nv_diachi)
VALUES 
    ('NV001', 'Pham Van D', '0987654321', '123 Nguyen Trai'),
    ('NV002', 'Doan Thi E', '0976543210', '456 Le Loi'),
    ('NV003', 'Hoang Van F', '0965432109', '789 Tran Hung Dao'),
    ('NV004', 'Nguyen Van G', '0954321098', '12 Tran Phu'),
    ('NV005', 'Tran Thi H', '0943210987', '34 Le Thanh Tong');


INSERT INTO DANH_MUC (dm_id, dm_ten)
VALUES 
    ('DM001', 'Ao'),
    ('DM002', 'Quan'),
    ('DM003', 'Phu Kien'),
    ('DM004', 'Giay'),
    ('DM005', 'Non');

//<Thằng sp_anh lấy ảnh từ thư muc Resources\Pictures>
//<Lưu ý là phải 2 "\\">
INSERT INTO SAN_PHAM (sp_id, sp_ten, sp_gia, sp_gioitinh, sp_anh, soluongton, dm_id)
VALUES 
    ('SP001', 'Ao Thun Nam', 150000, 'Nam', 'D:\\STUDY\\LT_WINDOW\\DO_AN\\Resources\\Pictures\\aothun.jpg', 50, 'DM001'),
    ('SP002', 'Quan Jean Nam', 300000, 'Nam', 'D:\\STUDY\\LT_WINDOW\\DO_AN\\Resources\\Pictures\\jeannamam.jpg', 30, 'DM002'),
    ('SP003', 'Ao So Mi Nu', 250000, 'Nu', 'D:\\STUDY\\LT_WINDOW\\DO_AN\\Resources\\Pictures\\sominu.jpg', 40, 'DM001'),
    ('SP004', 'Quan Dui Nu', 350000, 'Nu', 'D:\\STUDY\\LT_WINDOW\\DO_AN\\Resources\\Pictures\\shortnu.jpg', 20, 'DM002'),
    ('SP005', 'Kinh Mat', 200000, 'Unisex', 'D:\\STUDY\\LT_WINDOW\\DO_AN\\Resources\\Pictures\\kinhmat.jpg', 60, 'DM003'),
    ('SP006', 'Tui Xach Nu', 400000, 'Nu', 'D:\\STUDY\\LT_WINDOW\\DO_AN\\Resources\\Pictures\\tuixachnu.jpg', 25, 'DM003'),
    ('SP007', 'Giay The Thao Nam', 500000, 'Nam', 'D:\\STUDY\\LT_WINDOW\\DO_AN\\Resources\\Pictures\\giaythethaonam.jpg', 15, 'DM004'),
    ('SP008', 'Non Luoi Trai', 70000, 'Unisex', 'D:\\STUDY\\LT_WINDOW\\DO_AN\\Resources\\Pictures\\nonluoitrai.jpg', 100, 'DM005');


INSERT INTO HOA_DON (hd_id, hd_ngaylap, hd_tongthanhtoan, phuongthucthanhtoan, nv_id, kh_id)
VALUES 
    ('HD001', '2024-10-25', 650000, 'Tien mat', 'NV001', 'KH001'),
    ('HD002', '2024-10-26', 570000, 'Chuyen khoan', 'NV002', 'KH002'),
    ('HD003', '2024-10-27', 450000, 'Tien mat', 'NV003', 'KH003'),
    ('HD004', '2024-10-28', 800000, 'Chuyen khoan', 'NV004', 'KH004'),
    ('HD005', '2024-10-29', 320000, 'Tien mat', 'NV005', 'KH005');


INSERT INTO CHI_TIET_HOA_DON (sp_id, hd_id, soluong)
VALUES 
    ('SP001', 'HD001', 2),  -- 2 chiếc Áo Thun Nam trong hóa đơn HD001
    ('SP002', 'HD001', 1),  -- 1 chiếc Quần Jean Nam trong hóa đơn HD001
    ('SP003', 'HD002', 1),  -- 1 chiếc Áo Sơ Mi Nữ trong hóa đơn HD002
    ('SP004', 'HD002', 1),  -- 1 chiếc Quần Tây Nữ trong hóa đơn HD002
    ('SP005', 'HD003', 2),  -- 2 chiếc Kính Mắt trong hóa đơn HD003
    ('SP006', 'HD004', 1),  -- 1 chiếc Túi Xách Nữ trong hóa đơn HD004
    ('SP007', 'HD005', 2),  -- 2 đôi Giày Thể Thao Nam trong hóa đơn HD005
    ('SP008', 'HD005', 1);  -- 1 
