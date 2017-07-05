import { Component } from '@angular/core';

import { Motocykl } from '../Motocykle/Motocykl';
import { MotoService } from '../Services/moto.service';

@Component({
    templateUrl: 'app/AddMoto/add-moto.component.html',
    styleUrls: ['app/AddMoto/add-moto.component.css']
})

export class AddMotoComponent {
    moto: Motocykl = new Motocykl();

    constructor(private _motoService: MotoService) { }

    addMoto(): void {
        this._motoService.add(this.moto);
        this.moto = new Motocykl();
    }
}
