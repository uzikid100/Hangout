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

    loggedInUser: User;

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

    getUsers(): Observable<User[]> {
        return this.http.get<User[]>(this.controllerUrl);
    }

    get getLoggedInUser(): Observable<User> {
        // Ideally would get current user from authService
        return this.http.get<User>(this.controllerUrl + 1);
        // if (this.loggedInUser == null) {
        //     return MockUser;
        // }
        // return this.loggedInUser;
    }

    logIn(id: number) {

    }

}
