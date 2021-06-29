import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Patient } from './patient';

@Injectable()
export class DataService {

    private url = "/api/database";

    constructor(private http: HttpClient) {
    }

    getPatients() {
        return this.http.get(this.url);
    }
}