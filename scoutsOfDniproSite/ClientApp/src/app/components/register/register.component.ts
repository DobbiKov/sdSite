import { HttpErrorResponse } from '@angular/common/http';
import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { User } from '../../models/user';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.scss']
})
export class RegisterComponent implements OnInit {

  constructor(private http: HttpClient) { }

  public isReg: boolean = false;
  public errorText: string = "";

  register(email: string, password: string, firstName: string, lastName: string, forestName: string): any{
    var request = this.http.post('/api/Users/Register', {UserName: email, Password: password, FirstName: firstName, LastName: lastName, ForestName: forestName}, {headers: {'Content-Type': 'application/json'}});
    request.subscribe(
      (data:User) => {
        this.isReg = true;
      }, 
      (error:HttpErrorResponse) => {
        this.errorText = "Вы уже подали заявку, либо аккаунт с таким логином уже имеетя.";
      }
    );
    return request;
  }

  ngOnInit(): void {
  }

}