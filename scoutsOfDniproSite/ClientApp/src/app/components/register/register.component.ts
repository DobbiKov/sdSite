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
    if(email.length < 10){
      this.errorText = "Длина email'a должна быть не менее десяти символов.";
      return;
    }
    if(password.length < 8){
      this.errorText = "Длина пароля должна быть не менее восьми символов.";
      return;
    }
    if(firstName.length < 1){
      this.errorText = "Вы не ввели имя.";
      return;
    }
    if(lastName.length < 1){
      this.errorText = "Вы не ввели фамилию.";
      return;
    }
    if(forestName.length < 1){
      this.errorText = "Вы не ввели лесное имя.";
      return;
    }
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