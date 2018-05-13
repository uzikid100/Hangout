import { HttpClient } from "@angular/common/http";
import { ConfigProvider } from "./config.provider";
import { Injectable } from "@angular/core";

@Injectable()
export class FriendProvider {
    controllerName = 'Friends/';
    controllerUrl: string;

    constructor(private http: HttpClient, private configService: ConfigProvider) {
        this.controllerUrl = this.configService.fullApiUrl + this.controllerName;
    }

}