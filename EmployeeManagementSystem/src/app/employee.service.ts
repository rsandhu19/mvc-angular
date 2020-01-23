import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { map } from "rxjs/operators";
import { Observable } from "rxjs";
import { EmployeeInfo } from './employeeInfo';

@Injectable({
    providedIn: 'root'
})
export class EmployeeService {

    constructor(private httpClient: HttpClient) { }

    getEmployees(): Observable<EmployeeInfo> {
        return this.httpClient.get('https://localhost/api/employees').
            pipe(
                map((item: any) => item.map(p => <EmployeeInfo>
                    {
                    id: p.id,
                    firstName: p.firstName,
                    lastName: p.lastName,
                    role:p.role
                    })));
    }
}