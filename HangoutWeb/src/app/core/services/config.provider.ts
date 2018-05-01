import { Injectable } from "@angular/core";

@Injectable()
export class ConfigProvider {

    private apiUrl: string = 'http://localhost:49872/';

    get fullApiUrl(): string {
        return this.apiUrl + 'api/';
    }
}