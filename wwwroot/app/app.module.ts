import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpModule } from '@angular/http';
import { RouterModule } from '@angular/router';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import 'rxjs/Rx';

import { AppComponent } from './app.component';
import { HomeComponent } from './Components/home/home.component';
import { NavBarComponent } from './Components/Navbar/navbar.component';
import { LoginComponent } from './Components/login/login.component';
import { ClaimsComponent } from './Components/claims/claims.component';
import { QuotesComponent } from './Components/quotes/quotes.component';

import { AppRouting } from './app.routing';
import { AuthService } from './auth.service';
import { AuthHttp } from "./auth.http";



@NgModule({
    declarations: [
        AppComponent,
        HomeComponent,
        NavBarComponent,
        LoginComponent,
        ClaimsComponent,
        QuotesComponent
    ],
    imports: [
        BrowserModule,
        HttpModule,
        FormsModule,
        ReactiveFormsModule,
        RouterModule,
        AppRouting,
    ],
    providers: [
        AuthService,
        AuthHttp

    ],
    bootstrap: [
        AppComponent
    ],
})
export class AppModule { }