-- Active: 1666715464348@@SG-shaded-voice-9071-6836-mysql-master.servers.mongodirector.com@3306@Classroom

CREATE TABLE
    IF NOT EXISTS cars(
        id int NOT NULL AUTO_INCREMENT PRIMARY KEY,
        make VARCHAR(255) NOT NULL,
        model VARCHAR(255) NOT NULL,
        year int NOT NULL CHECK (year >= 1886),
        price DECIMAL(10, 2) NOT NULL CHECK (price >= 0),
        description VARCHAR(255),
        imgUrl VARCHAR(255) DEFAULT "https://www.autolist.com/assets/listings/default_car.jpg",
        userId VARCHAR(255) NOT NULL
    );

INSERT INTO
    cars(
        make,
        model,
        year,
        price,
        description,
        imgUrl,
        userId
    )
VALUES (
        "KFC",
        "Bucket Tré",
        1985,
        999,
        "Yum Yum!!",
        "https://www.autolist.com/assets/listings/default_car.jpg"
    );

SELECT * FROM cars;