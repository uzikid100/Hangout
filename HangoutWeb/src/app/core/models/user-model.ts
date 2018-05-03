import { Component } from "@angular/core";

export class User {
    public Id: number;
    public Username: string;
    public Password: string;
    public FirstName: string;
    public LastName: string;
    public Email: string;
    public Description: string;
    public Reputation: number;
    public Avatar: any
    public IsAuthenticated: boolean;

    json(json: any): User {
        let user = Object.create(User.prototype);
        Object.assign(user, json);
        return user;
    }
}