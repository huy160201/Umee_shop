-- CATEGORY
CREATE TABLE website_bandan_umee.category (
  CategoryId char(36) NOT NULL COMMENT 'Mã thể loại',
  CategoryName varchar(255) NOT NULL COMMENT 'Tên thể loại',
  PRIMARY KEY (CategoryId)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 8192,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_0900_ai_ci,
COMMENT = 'Thể loại sản phẩm';

-- PRODUCT
CREATE TABLE website_bandan_umee.product (
  ProductId char(36) NOT NULL COMMENT 'Mã sản phẩm',
  CategoryId char(36) DEFAULT NULL COMMENT 'Mã thể loại',
  ProductName varchar(255) NOT NULL COMMENT 'Tên sản phẩm',
  Amount int(11) DEFAULT NULL COMMENT 'Số lượng có',
  AmountSold int(11) DEFAULT NULL COMMENT 'Số lượng đã bán',
  Content text DEFAULT NULL COMMENT 'Mô tả chi tiết sản phẩm',
  PRIMARY KEY (ProductId)
)
ENGINE = INNODB,
AVG_ROW_LENGTH = 8192,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_0900_ai_ci,
COMMENT = 'Sản phẩm';

ALTER TABLE website_bandan_umee.product
ADD CONSTRAINT product_ibfk_1 FOREIGN KEY (CategoryId)
REFERENCES website_bandan_umee.category (CategoryId);

-- ACCOUNT
CREATE TABLE website_bandan_umee.account (
  AccountId char(36) NOT NULL COMMENT 'Mã tài khoản',
  FullName varchar(50) NOT NULL COMMENT 'Họ và tên',
  Admin tinyint(1) DEFAULT 0 COMMENT 'Phân quyền, 0 - Khách hàng, 1 - Admin',
  Email varchar(255) DEFAULT NULL COMMENT 'Địa chỉ Email',
  DateOfBirth date DEFAULT NULL COMMENT 'Ngày tháng năm sinh',
  Gender bit(1) DEFAULT b'0' COMMENT 'Giới tính, 0 - Nam, 1 - Nữ',
  PRIMARY KEY (AccountId)
)
ENGINE = INNODB,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_0900_ai_ci,
COMMENT = 'Tài khoản';

-- RECEIPT
CREATE TABLE website_bandan_umee.receipt (
  OrderId char(36) NOT NULL COMMENT 'Mã đơn hàng',
  AccountId char(36) NOT NULL COMMENT 'Khóa ngoại, mã tài khoản',
  CreatedAt timestamp NULL DEFAULT CURRENT_TIMESTAMP COMMENT 'Ngày tạo đơn hàng',
  Status tinyint(3) DEFAULT 0 COMMENT 'Trạng thái đơn hàng, 0 - chưa duyệt, 1 - đã duyệt',
  TransportFee int(11) DEFAULT NULL COMMENT 'Phí vận chuyển',
  ReceiverName varchar(50) DEFAULT NULL COMMENT 'Tên người nhận',
  Address varchar(255) DEFAULT NULL COMMENT 'Địa chỉ người nhận',
  PhoneNumber int(11) DEFAULT NULL COMMENT 'Số điện thoại người nhận',
  PRIMARY KEY (OrderId)
)
ENGINE = INNODB,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_0900_ai_ci,
COMMENT = 'Đơn hàng';

ALTER TABLE website_bandan_umee.receipt
ADD CONSTRAINT receipt_ibfk_1 FOREIGN KEY (AccountId)
REFERENCES website_bandan_umee.account (AccountId);

-- RECEIPT DETAIL
CREATE TABLE website_bandan_umee.receipt_detail (
  OrderId char(36) NOT NULL COMMENT 'Mã đơn hàng',
  ProductId char(36) NOT NULL COMMENT 'Mã sản phẩm',
  Price int(11) NOT NULL COMMENT 'Giá đơn hàng',
  Amount int(11) NOT NULL COMMENT 'Số lượng sản phẩm'
)
ENGINE = INNODB,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_0900_ai_ci,
COMMENT = 'Chi tiết đơn hàng';

ALTER TABLE website_bandan_umee.receipt_detail
ADD CONSTRAINT receipt_detail_ibfk_1 FOREIGN KEY (OrderId)
REFERENCES website_bandan_umee.receipt (OrderId);

ALTER TABLE website_bandan_umee.receipt_detail
ADD CONSTRAINT receipt_detail_ibfk_2 FOREIGN KEY (ProductId)
REFERENCES website_bandan_umee.product (ProductId);

-- IMAGE
CREATE TABLE website_bandan_umee.image (
  ImageId char(36) NOT NULL,
  ProductId char(36) NOT NULL,
  Url varchar(255) NOT NULL,
  PRIMARY KEY (ImageId)
)
ENGINE = INNODB,
CHARACTER SET utf8mb4,
COLLATE utf8mb4_0900_ai_ci,
COMMENT = 'Thông tin ảnh sản phẩm';

ALTER TABLE website_bandan_umee.image
ADD CONSTRAINT image_ibfk_1 FOREIGN KEY (ProductId)
REFERENCES website_bandan_umee.product (ProductId);