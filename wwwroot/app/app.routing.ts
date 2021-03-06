import { ModuleWithProviders } from "@angular/core";
import { Routes, RouterModule } from "@angular/router";
import { HomeComponent } from './Components/home/home.component';
import { QuotesComponent } from './Components/quotes/quotes.component';
import { ClaimsComponent } from './Components/claims/claims.component';
import { LoginComponent } from './Components/login/login.component';
const appRoutes: Routes = [
    {
        path: "",
        component: HomeComponent
    },
    {
        path: "home",
        redirectTo: ""
    },
    {
        path: "quotes",
        component: QuotesComponent
    },
    {
        path: "claims",
        component: ClaimsComponent
    },
    {
        path: "login",
        component: LoginComponent
    }
];
export const AppRoutingProviders: any[] = [
];
export const AppRouting: ModuleWithProviders = RouterModule.forRoot(appRoutes);