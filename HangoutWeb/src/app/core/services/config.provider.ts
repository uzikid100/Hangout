import { Injectable } from "@angular/core";

@Injectable()
export class ConfigProvider {

    private apiUrl: string = 'http://localhost:49873/';

    get fullApiUrl(): string {
        return this.apiUrl + 'api/';
    }
}