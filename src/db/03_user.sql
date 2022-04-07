CREATE TABLE user (
   id             INTEGER                    NOT NULL PRIMARY KEY,
   first_name     VARCHAR(30)                NOT NULL,
   last_name      VARCHAR(30)                NOT NULL,
   phone_number   VARCHAR(30),
   email          VARCHAR(30),
   deleted        BOOLEAN DEFAULT false
);