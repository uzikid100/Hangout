import { Component, Injectable } from "@angular/core";
import { HttpClient } from '@angular/common/http';
import { ConfigProvider } from './config.provider';
import { Observable } from 'rxjs/Observable';
import { of } from 'rxjs/Observable/of';
import { User } from '../models/user-model';
import 'rxjs';

@Injectable()
export class UserProvider {

    private controllerName: string = 'Users/';
    private controllerUrl: string;

    user: User;
    constructor(private http: HttpClient, private configService: ConfigProvider) {
        this.controllerUrl = this.configService.fullApiUrl + this.controllerName;
    }

    addNewUser(user: User): Observable<any> {
        return this.http.post<User>(this.controllerUrl, user);
    }

    getUser(userName: string): Observable<any> {
        return this.http.get<User>(this.controllerUrl + userName);
        // .map((res) => this.user = res);
    }
}
