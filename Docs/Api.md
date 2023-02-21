# Buber Dinner API

## BuberDinner Api
  - [Auth](#auth)
    - [Register](#register)
      - [Register Request](#register-request)
      - [Register Response](#register-response)
    - [Login](#login)
      - [Login Request](#login-request)
      - [Login Response](#login-response)
  - [Contact](#contact)

## Auth

## Register

```js
POST {{ host }}/auth/register
```

## Register Request
```json
{
  "firstName":"Lopes",
  "lastName":"Boa",
  "email":"lopesboa@email.com",
  "password":"mayStrongPassword",
}
```

## Register Response
```js
200 OK
```
```json
{
  "id":"b53aac99-b855-4357-ab2f-a28d803229d0",
  "firstName":"Lopes",
  "lastName":"Boa",
  "email":"lopesboa@email.com",
  "password":"mayStrongPassword",
}
```

## Login
```js
POST {{ host }}/auth/login
```
## Login Request
```json
{
  "email":"lopesboa@email.com",
  "password":"mayStrongPassword",
}
```
## Login Response
```js
200 OK
```
```json
{
  "id":"b53aac99-b855-4357-ab2f-a28d803229d0",
  "firstName":"Lopes",
  "lastName":"Boa",
  "email":"lopesboa@email.com",
  "password":"mayStrongPassword",
}
```

## Contact
Created by [@lopesboa](https://github.com/lopesboa) - feel free to contact me!




