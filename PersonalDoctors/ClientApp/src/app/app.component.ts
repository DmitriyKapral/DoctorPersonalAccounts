import { Component, OnInit } from '@angular/core';
import { DataService } from './data.service';
import { Patient } from './patient';

@Component({
    selector: 'app',
    templateUrl: './app.component.html',
    providers: [DataService]
})
export class AppComponent implements OnInit {

    patient: Patient = new Patient();   // изменяемый товар
    patients: Patient[];                // массив товаров

    constructor(private dataService: DataService) { }

    ngOnInit() {
        this.loadPatients();    // загрузка данных при старте компонента  
    }
    // получаем данные через сервис
    loadPatients() {
        this.dataService.getPatients()
            .subscribe((data: Patient[]) => this.patients = data);
    }
}