import { Component, OnInit } from '@angular/core';
import { EmployeeService } from '../employee.service';

@Component({
    selector: 'app-gitrepos',
    templateUrl: './employee.component.html',
    styleUrls: ['./employee.component.css']
})
export class EmployeeComponent implements OnInit {
    public employeeList;
    constructor(private empservice: EmployeeService) { }

    ngOnInit() {
        this.loadAllEmployees();
    }

    public loadAllEmployees() {
        this.empservice.getEmployees().subscribe((data) => {
            this.employeeList = data;
        });
    }
}
