import * as tslib_1 from "tslib";
import { Component } from '@angular/core';
let EmployeeComponent = class EmployeeComponent {
    constructor(empservice) {
        this.empservice = empservice;
    }
    ngOnInit() {
        this.loadAllEmployees();
    }
    loadAllEmployees() {
        this.empservice.getEmployees().subscribe((data) => {
            this.employeeList = data;
        });
    }
};
EmployeeComponent = tslib_1.__decorate([
    Component({
        selector: 'app-gitrepos',
        templateUrl: './employee.component.html',
        styleUrls: ['./employee.component.css']
    })
], EmployeeComponent);
export { EmployeeComponent };
//# sourceMappingURL=employee.component.js.map