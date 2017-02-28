import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpModule } from '@angular/http';
import 'rxjs/Rx';

// import our application component
import { AppComponent } from './app.component';
import { HomeComponent } from './Components/Home/home.component';
import { NavBarComponent } from './Components/Navbar/navbar.component';

@NgModule({
    declarations: [
        AppComponent,
        HomeComponent,
        NavBarComponent
    ],
    imports: [
        BrowserModule,
        HttpModule
    ],
    providers: [
    ],
    bootstrap: [
        AppComponent
    ],
})
export class AppModule { }