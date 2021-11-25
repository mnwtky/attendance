# テーブル設計

## Employee テーブル

| Column     | Type   | Options     |
| ---------- | ------ | ----------- |
| email      | string | null: false |
| password   | string | null: false |
| name       | string | null: false |
| profile    | text   | null: false |
| occupation | text   | null: false |
| position   | text   | null: false |


## Attendance テーブル

| Column      | Type      | Options         |
| ----------- | --------- | --------------- |
| WorkingDate | DateTime  | nullable: false |
| ClonkingIn  | DateTime  | nullable: false |
| ClockingOut | DateTime  | nullable: false |
| BreakeTime  | decimal   | nullable: false |
| WorkingTime | decimal   | nullable: false |
