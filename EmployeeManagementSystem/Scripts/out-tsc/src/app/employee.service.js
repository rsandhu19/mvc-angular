import * as tslib_1 from "tslib";
import { Injectable } from '@angular/core';
import { map } from "rxjs/operators";
let EmployeeService = class EmployeeService {
    constructor(httpClient) {
        this.httpClient = httpClient;
    }
    getEmployees() {
        return this.httpClient.get('https://localhost/api/employees').
            pipe(map((item) => item.map(p => ({
            id: p.id,
            firstName: p.firstName,
            lastName: p.lastName,
            role: p.role
        }))));
    }
};
EmployeeService = tslib_1.__decorate([
    Injectable({
        providedIn: 'root'
    })
], EmployeeService);
export { EmployeeService };
//# sourceMappingURL=employee.service.js.map