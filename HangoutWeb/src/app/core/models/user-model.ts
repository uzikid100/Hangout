import { Component } from "@angular/core";

export class User {
    public id: number;
    public username: string;
    public password: string;
    public firstName: string;
    public lastName: string;
    public email: string;
    public description: string;
    public reputation: number;
    public avatar: any
    public isAuthenticated: boolean;

    // constructor(jsonObj = {} as User) {
    //     const val = Object.getPrototypeOf(this);
    //     Object.assign(val, jsonObj);
    //     console.log('Component obj');
    //     console.log(this);
    // }
    // json(json: any): User {
    //     let user = Object.create(User.prototype);
    //     Object.assign(user, json);
    //     return user;
    // }
}