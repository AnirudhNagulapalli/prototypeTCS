import { Component, OnInit } from '@angular/core';
import { RepositoryService } from './../../shared/services/repository.service';
import { Employee } from '../../_i../../_interfaces/employee.model'
import { Router } from '@angular/router';

@Component({
  selector: 'app-employee-list',
  templateUrl: './employee-list.component.html',
  styleUrls: ['./employee-list.component.css']
})
export class EmployeeListComponent implements OnInit {

  public employees: Employee[];

  constructor(private repository: RepositoryService, private router: Router) { }

  ngOnInit() {
    this.getAllEmployees();
  }

  public getAllEmployees() {
    let apiAddress: string = "";
    this.repository.getData(apiAddress)
    .subscribe(res => {
      this.employees = res as Employee[];
    })
  }

  
}
