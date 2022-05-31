# NET6_WebAPI_JWT_Registration_Login

This is a demo using .NET 6 to show a web API project for authentication such register and login, and role based authorization.

1. In the register method, we create password with salt and hash code
2. In the login method, we compare hash code to verify the login user
3. The JWT token is created once the user login.
