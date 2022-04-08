CREATE TABLE user (
   id                INTEGER                          NOT NULL PRIMARY KEY,
   user_id           INTEGER REFERENCES user (id)     NOT NULL,
   asset_id          INTEGER REFERENCES asset (id)    NOT NULL,
   date_borrowed     DATE                             NOT NULL,
   date_returned     DATE
);