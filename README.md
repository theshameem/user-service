# User Microservice

User Microservice is responsible for **user identity, authentication, profile management, and notification preferences**.  
It also acts as the **central identity (Auth) service** for other microservices.

---

## Responsibilities

- Authentication & Authorization (JWT based)
- User profile management
- Notification preferences
- Publishing user-related events via RabbitMQ

---

## Features

### Phase 1 – Core
- User Registration
- User Login (JWT)
- Get User Profile
- Update User Profile
- Role support (User, Admin)
- Basic validation

### Phase 2 – Security & Control
- Refresh Token
- Change Password
- Soft Delete User
- User Status (Active / Blocked)

### Phase 3 – Microservice Ready
- Notification Preferences
- Publish events to RabbitMQ
- Health Check endpoint

---

## Architecture

This service follows **Clean Architecture + DDD-lite**.

