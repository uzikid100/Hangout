import { Component, Injectable } from "@angular/core";
import { HttpClient } from '@angular/common/http';
import { ConfigProvider } from './config.provider';
import { Observable } from 'rxjs/Observable';
import { of } from 'rxjs/Observable/of';
import { User } from '../models/user-model';
import 'rxjs';
import { MockUser } from "../mocks/mock-user";

@Injectable()
export class UserProvider {

    private controllerName: string = 'Users/';
    private controllerUrl: string;

    private loggedInUser: User;

    constructor(private http: HttpClient, private configService: ConfigProvider) {
        this.controllerUrl = this.configService.fullApiUrl + this.controllerName;
    }

    addNewUser(user: User): Observable<any> {
        return this.http.post<User>(this.controllerUrl, user).map(response => {
            return this.loggedInUser = response as User;
        });
    }

    getUser(id: number): Observable<User> {
        return this.http.get<User>(this.controllerUrl + id);
    }

    getUserByUsername(username: string): Observable<User> {
        return this.http.get<User>(this.controllerUrl + username);
    }

    getUsers(): Observable<User[]> {
        return this.http.get<User[]>(this.controllerUrl);
    }

    get getLoggedInUser(): Observable<User> {
        if (this.loggedInUser)
            return of(this.loggedInUser);
        return this.http.get<User>(this.controllerName + 1);
    }

    logIn(username: string): Observable<User> {
        const result = this.getUserByUsername(username);
        if (result !== null) {
            result.subscribe(user => {
                console.log(user);
                return this.loggedInUser = user;
            })
        }
        else return null;
    }

    updateFriendsList(users: User[]): void {
        this.http.put(this.controllerUrl, users);
    }

}
