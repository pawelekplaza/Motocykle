import { Component, OnInit } from '@angular/core';

import { Motocykl } from '../Motocykle/Motocykl';
import { MotoService } from '../Services/moto.service';

@Component({
    templateUrl: 'app/MotoList/moto-list.component.html',
    styleUrls: [ 'app/MotoList/moto-list.component.css' ]
})

export class MotoListComponent implements OnInit {
    motoList: Motocykl[];

    constructor(private _motoService: MotoService) { } 

    ngOnInit(): void {
        this._motoService.getAll()
            .subscribe(value => this.motoList = value,
            error => console.log(error));                        
    }
}