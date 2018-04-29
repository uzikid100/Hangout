import { Component, Injectable } from "@angular/core";
import { Http, HttpModule } from '@angular/http';
import { ConfigProvider } from './config.provider';
import { Observable } from 'rxjs/Observable';
import { of } from 'rxjs/Observable/of';
import { User } from '../models/user-model';

@Injectable()
export class UserProvider {

    private controllerName: string = 'Users/';
    private controllerUrl: string;

    user: User;
    constructor(private http: Http, private configService: ConfigProvider) {
        this.controllerUrl = this.configService.fullApiUrl + this.controllerName;
    }

    addNewUser(user: User): Observable<any> {
        return this.http.post(this.controllerUrl, user);
    }

    getUser(userName: string): Observable<any> {
        return this.http.get(this.controllerUrl + userName);
    }
}
