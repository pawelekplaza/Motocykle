import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

import { Motocykl } from '../Motocykle/Motocykl';
import { MotoService } from '../Services/moto.service';

@Component({
    templateUrl: 'app/MotoList/moto-list.component.html',
    styleUrls: [ 'app/MotoList/moto-list.component.css' ]
})

export class MotoListComponent implements OnInit {
    motoList: Motocykl[];

    constructor(private _motoService: MotoService,
                private _router: Router) { } 

    ngOnInit(): void {
        this._motoService.getAll()
            .subscribe(value => this.motoList = value,
            error => console.log(error));                        
    }

    private goToDetails(id: number): void {
        this._router.navigate([`/motocykle/${id}`]);
    }

    private delete(id: number): void {
        let motoId = this.motoList.findIndex(v => v.id === id);
        
        if (this._motoService.delete(id)) {
            this.motoList.splice(motoId, 1);
        }
    }
}