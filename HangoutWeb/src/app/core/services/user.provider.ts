import { Component, Injectable } from "@angular/core";
import { Http } from '@angular/http';
import { ConfigProvider } from './config.provider';
import { Observable } from 'rxjs/Observable';
import { of } from 'rxjs/Observable/of';
import { User } from '../models/user-model';

@Injectable()
export class UserProvider {

    private controllerName: string = 'Users/';
    private controllerUrl: string;

    constructor(private http: Http, private configService: ConfigProvider) {
        this.controllerUrl = this.configService.fullApiUrl + this.controllerName;
    }

    getUser(userName: string, password: string) {
        // return this.http.get<User>(this.controllerUrl).map(res => res.json());
    }
}
