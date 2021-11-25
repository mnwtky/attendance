<img width="402" alt="スクリーンショット 2021-11-25 13 13 05" src="https://user-images.githubusercontent.com/69100365/143378794-5e68abf4-f986-4c5f-b0e6-668d20293d03.png">


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
