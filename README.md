# テーブル設計

## Employee テーブル

| Column     | Type   | Options         |
| ---------- | ------ | --------------- |
| ID         | int    | nullable: false |
| Name       | string | nullable: false |
| Email      | string | nullable: false |
| password   | string | nullable: false |

## Attendance テーブル

| Column      | Type      | Options         |
| ----------- | --------- | --------------- |
| ID          | int       | nullable: false |
| WorkingDate | DateTime  | nullable: false |
| ClonkingIn  | DateTime  | nullable: false |
| ClockingOut | DateTime  | nullable: false |
| BreakeTime  | decimal   | nullable: false |
| WorkingTime | decimal   | nullable: false |
| EmployeeID  | int       | nullable: true  |
