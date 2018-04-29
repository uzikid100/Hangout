import { Injectable } from '@angular/core';
import { Http } from '@angular/http';
import { User } from '../models/user-model';

@Injectable()
export class AuthProvider {

    private user: User;

    constructor(private http: Http) { }

    validInput(): boolean {
        // Should validate syntax of login entry
        return false;
    }

    isAuthenticated(): boolean {
        // Should check if existing user and valid credentials 
        return false;
    }

    get authenticatedUser() {
        // If isAuthenticated and validInput, should return the 
        return
    }
}