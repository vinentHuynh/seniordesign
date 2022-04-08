CREATE TABLE asset_location (
   id             INTEGER        NOT NULL PRIMARY KEY,
   value          VARCHAR(10)    NOT NULL,
   description    VARCHAR(30)    NOT NULL
);

INSERT INTO asset_location (id, value, description)
VALUES (1, 'loc1', 'lobby'),
       (2, 'loc2', 'office 1'),
       (3, 'loc3', 'office 2'),
       (4, 'loc4', 'break room'),
       (5, 'loc5', 'print room');


CREATE TABLE asset_status (
   id             INTEGER        NOT NULL PRIMARY KEY,
   value          VARCHAR(10)    NOT NULL,
   description    VARCHAR(30)    NOT NULL,
   last_updated   DATE           NOT NULL
);

INSERT INTO asset_status (id, value, description, last_updated)
VALUES (1, 'A', 'active'),
       (2, 'I', 'inactive'),
       (3, 'U', 'under maintenance'),
       (4, 'Q', 'requested'),
       (5, 'B', 'borrowed'),
       (6, 'R', 'returned');


CREATE TABLE asset_type (
   id             INTEGER        NOT NULL PRIMARY KEY,
   value          VARCHAR(10)    NOT NULL,
   description    VARCHAR(30)    NOT NULL,
);

INSERT INTO asset_type (id, value, description)
VALUES (1, 'type1', 'computer'),
       (2, 'type2', 'monitor'),
       (3, 'type3', 'keyboard'),
       (4, 'type4', 'printer');


CREATE TABLE asset (
   id                INTEGER                                         NOT NULL PRIMARY KEY,
   name              VARCHAR(30)                                     NOT NULL,
   asset_location_id INTEGER REFERENCES asset_location (id)          NOT NULL,
   asset_status_id   INTEGER REFERENCES asset_status (id)            NOT NULL,
   asset_type_id     INTEGER REFERENCES asset_type (id)              NOT NULL,
   model_number      VARCHAR(30),
   serial_number     VARCHAR(30),
   warranty_date     DATE,
   notes             VARCHAR(255),
   deleted           BOOLEAN DEFAULT false
);