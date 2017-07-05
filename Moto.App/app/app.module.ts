import { NgModule }      from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule } from '@angular/router';
import { HttpModule } from '@angular/http';
import { FormsModule } from '@angular/forms';

import { AppComponent } from './app.component';
import { NavbarComponent } from './Navbar/navbar.component';
import { HomeComponent } from './Home/home.component';
import { MotoService } from './Services/moto.service';
import { MotoListComponent } from './MotoList/moto-list.component';
import { AddMotoComponent } from './AddMoto/add-moto.component';
import { MotoDetailsComponent } from './MotoDetails/moto-details.component';

@NgModule({
    imports: [
        BrowserModule,
        HttpModule,
        FormsModule,
        RouterModule.forRoot([
            { path: 'home', component: HomeComponent },
            { path: 'motocykle', component: MotoListComponent },
            { path: 'motocykle/:id', component: MotoDetailsComponent },
            { path: 'dodaj', component: AddMotoComponent },
            { path: '', redirectTo: 'home', pathMatch: 'full' },
            { path: '**', redirectTo: 'home', pathMatch: 'full' }],
            { useHash: true })
    ],
  declarations: [
      AppComponent,
      NavbarComponent,
      HomeComponent,
      MotoListComponent,
      AddMotoComponent,
      MotoDetailsComponent
    ],
  providers: [
      MotoService
    ],
  bootstrap:    [ AppComponent ]
})
export class AppModule { }
