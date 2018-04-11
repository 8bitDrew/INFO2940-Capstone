/********************************************************
* This script creates the database named computer_shop 
*********************************************************/

DROP DATABASE IF EXISTS computer_shop;
CREATE DATABASE computer_shop;
USE computer_shop;

-- create the tables for the database
CREATE TABLE categories (
  category_id        INT            PRIMARY KEY   AUTO_INCREMENT,
  category_name      VARCHAR(255)   NOT NULL      UNIQUE
);

CREATE TABLE products (
  product_id         INT            PRIMARY KEY   AUTO_INCREMENT,
  category_id        INT            NOT NULL,
  product_code       VARCHAR(10)    NOT NULL      UNIQUE,
  product_name       VARCHAR(255)   NOT NULL,
  description        TEXT           NOT NULL,
  list_price         DECIMAL(10,2)  NOT NULL,
  CONSTRAINT products_fk_categories
    FOREIGN KEY (category_id)
    REFERENCES categories (category_id)
);

CREATE TABLE customers (
  customer_id           INT            PRIMARY KEY   AUTO_INCREMENT,
  email_address         VARCHAR(255)   NOT NULL      UNIQUE,
  first_name            VARCHAR(60)    NOT NULL,
  last_name             VARCHAR(60)    NOT NULL,
  line1              	VARCHAR(60)    NOT NULL,
  line2              	VARCHAR(60)                  DEFAULT NULL,
  city               	VARCHAR(40)    NOT NULL,
  state              	VARCHAR(2)     NOT NULL,
  zip_code           	VARCHAR(10)    NOT NULL
);

CREATE TABLE orders (
  order_id          INT            PRIMARY KEY  AUTO_INCREMENT,
  customer_id       INT            NOT NULL,
  order_date        DATETIME,
  product_id		INT,
  quantity			INT,
  price				DECIMAL(10,2),
  ship_date			DATETIME,
  CONSTRAINT orders_fk_customers
    FOREIGN KEY (customer_id)
    REFERENCES customers (customer_id)
);

CREATE TABLE administrators (
  admin_id           INT            PRIMARY KEY   AUTO_INCREMENT,
  email_address      VARCHAR(255)   NOT NULL,
  username			 VARCHAR(20)	NOT NULL,
  password           VARCHAR(255)   NOT NULL,
  first_name         VARCHAR(255)   NOT NULL,
  last_name          VARCHAR(255)   NOT NULL
);

-- Insert data into the tables
INSERT INTO categories (category_id, category_name) VALUES
(1, 'Motherboards'),
(2, 'CPUs'),
(3, 'Graphics Chips'), 
(4, 'Hard Drives'),
(5, 'Memory');

INSERT INTO products (product_id, category_id, product_code, product_name, description, list_price) VALUES
	(DEFAULT, 
    1, 
    'maximus', 
    'ASUS ROG Maximus VIII Hero Motherboard', 
    'Honed and optimized for perfectly-balanced enthusiast-grade gaming desktops', 
    '219.99'),

	(DEFAULT, 
    1, 
    'z97', 
    'MSI Gaming Z97 Motherboard', 
    'MSI GAMING motherboards are designed to provide gamers with best-in-class features and technology. Backed by the imposing looks of MSIs Dragon, each motherboard is an engineering masterpiece tailored to gaming perfection.', 
    '149.99'),
    
	(DEFAULT, 
    1, 
    'x99', 
    'ASRock X99 Extreme4 Motherboard', 
    'ASRock Super Alloy motherboards are built for performance with top of the line features.', 
    '200.99'),
    
    (DEFAULT, 
    2, 
    'i7-5820k', 
    'Intel Core i7-5820K 6-Core CPU', 
    'Punch up the power in everything you do with the Intel Core i7-5820K Desktop Processor. It delivers significant improvement in performance over previous generation processors, resulting in great system performance and responsiveness, strong security, and exceptional virtualization capability.', 
    '349.99'),
    
    (DEFAULT, 
    2, 
    'i5-6600k', 
    'Intel Core i5-6600K Quad-Core CPU', 
    'The new standard for PC performance has arrived—6th Generation Intel® Core™ processors! Our blazing fast, feature packed processor family with built-in security is ready to take your productivity, creativity and 3D gaming to the next level.', 
    '254.99'),
    
    (DEFAULT, 
    2, 
    'i3-4160', 
    'Intel Core i3-4160 Hasell Dual-Core CPU', 
    'The Intel 4th generation Core i3-4160 processor is based on the new 22nm Haswell Microarchitecture for improved CPU performance. Advanced power management innovations help keep power consumption in check. New compute instructions ensure enhanced performance per cycle. Improved Intel integrated graphics enables discrete-level graphics performance. Extract more power from your Haswell core-based processor.', 
    '119.99'),
    
    (DEFAULT, 
    3, 
    'GTX980Ti', 
    'EVGA GeForce GTX 980 Ti', 
    'Ti. The most powerful two letters in the world of GPUs. When paired with our flagship gaming GPU – GeForce GTX 980 – it enables new levels of performance and capabilities. Accelerated by the groundbreaking NVIDIA Maxwell™ architecture, GTX 980 Ti delivers an unbeatable 4K and virtual reality experience.', 
    '629.99'),
    
    (DEFAULT, 
    3, 
    'GTX970', 
    'Gigabyte GeForce GTX 970', 
    'G1 GAMING Graphics Cards are forged with only the top-notch GPU via the very own GPU Gauntlet and Ultra Durable VGA components to ensure highest performance without compromising system reliability. Combined with the WINDFORCE cooling system and ultra HD support, gamers can immerse themselves in the most enriched gaming environment than ever before', 
    '309.99'),
    
    (DEFAULT, 
    3, 
    'R7-370', 
    'XFX Radeon  R7 370', 
    'XFX Radeon R7 370 graphics card deliver incredible online gaming performance, helping you crush the competition with high-performance and visual realism that take your skills to the next level', 
    '159.99'),
    
    (DEFAULT, 
    4, 
    'WD5TBHDD', 
    'Western Digital 5TB Hard Disk Drive', 
    'Solid performance and reliability for everyday computing.', 
    '219.99'),
    
    (DEFAULT, 
    4, 
    'SG1TBHDD', 
    'Seagate 1TB Hard Disk Drive', 
    'The Seagate Desktop HDD is the one drive for every desktop system need, supported by 30 years of trusted performance, reliability and simplicity', 
    '51.99'),	
    
    (DEFAULT, 
    4, 
    '850EVOSSD', 
    'Samsung 850 EVO 500GB Solid State Drive', 
    'A higher caliber SSD with enhanced performance and endurance', 
    '149.99'),
    
    (DEFAULT, 
    5, 
    'GS16GB', 
    'G.Skill Ripjaws V Series 16GB SDRAM', 
    'With a new generation, comes a new heat spreader design concept. Game in style; work in style. Ripjaws V is the newest member of the classic performance Ripjaws family, featuring suave new looks in five illuminating colors: Blazing Red, Steel Blue, Radiant Silver, Gunmetal Gray, and Classic Black.', 
    '84.99'),
    
    (DEFAULT, 
    5, 
    'CV8GB', 
    'Corsair Vengeance 8GB SDRAM', 
    'Like the legendary Dominator, enthusiast-grade Vengeance DRAM is designed for stability, stringently factory-tested, and backed by our limited lifetime warranty. And, we know that great looks are as important as great performance. This is why Vengeance modules come in a variety of colors to match your components and let you build your system just the way you want it. ', 
    '38.99'),
    
    (DEFAULT, 
    5, 
    'CV32GB',
    'Corsair Vengeance LPX 32GB SDRAM', 
    'Vengeance LPX memory is designed for high-performance overclocking. The heatspreader is made of pure aluminum for faster heat dissipation, and the eight-layer PCB helps manage heat and provides superior overclocking headroom. Each IC is individually screened for performance potential.', 
    '169.99');
	
INSERT INTO customers (customer_id, email_address, first_name, last_name, line1, line2, city, state, zip_code) VALUES
(DEFAULT, 'bruce.banner@yahoo.com', 'Bruce', 'Banner', '100 East Ridgewood Ave.', '', 'Paramus', 'NJ', '07652'),
(DEFAULT, 'tstark63@gmail.com', 'Tony', 'Stark', '16285 Wendell St.', '', 'Omaha', 'NE', '68135'),
(DEFAULT, 'blackwidow@solarone.com', 'Natasha', 'Romanov', '19270 NW Cornell Rd.', '', 'Beaverton', 'OR', '97006'),
(DEFAULT, 'thundergod@hotmail.com', 'Thor', 'Odinson', '186 Vermont St.', 'Apt. 2', 'San Francisco', 'CA', '94110'),
(DEFAULT, 'avenger1@gmail.com', 'Steve', 'Rogers', '6982 Palm Ave.', '', 'Fresno', 'CA', '93711'),
(DEFAULT, 'b.barnes@sbcglobal.net', 'Bucky', 'Barnes', '23 Mountain View St.', '', 'Denver', 'CO', '80208'),
(DEFAULT, 'hawkeye@yahoo.com', 'Clint', 'Barton', '7361 N. 41st St.', 'Apt. B', 'New York', 'NY', '10012'),
(DEFAULT, 'col_fury@shield.gov', 'Nick', 'Fury', '2381 Buena Vista St.', '', 'Los Angeles', 'CA', '90023');

INSERT INTO orders (order_id, customer_id, order_date, product_id, quantity, price, ship_date) VALUES
(1, 1, '2015-03-28 09:40:28', 1, 1, 219.99, '2015-03-29 10:15:00'),
(2, 2, '2015-03-28 11:23:20', 4, 2, 699.98, '2015-03-30 12:43:00'),
(3, 1, '2015-03-29 09:44:58', 10, 1, 219.99, '2015-04-01 08:24:00'),
(4, 3, '2015-03-30 15:22:31', 7, 1, 629.99, '2015-03-30 18:45:00'),
(5, 4, '2015-03-31 05:43:11', 10, 4, 879.96, '2015-04-03 08:15:00'),
(6, 5, '2015-03-31 18:37:22', 13, 1, 84.99, '2015-04-01 13:42:00'),
(7, 6, '2015-04-01 23:11:12', 3, 1, 200.99, '2015-04-02 08:15:00'),
(8, 7, '2015-04-02 11:26:38', 5, 2, 254.99, '2015-04-03 12:45:00'),
(9, 4, '2015-04-03 12:22:31', 2, 1, 149.99, '2015-04-05 09:32:00');

INSERT INTO administrators (admin_id, email_address, username, password, first_name, last_name) VALUES
(1, 'admin@infoconsulting.com', 'admin', 'secret', 'Admin', 'User');