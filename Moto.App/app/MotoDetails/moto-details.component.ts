import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

import { Motocykl } from '../Motocykle/Motocykl';
import { MotoService } from '../Services/moto.service';

@Component({
    templateUrl: 'app/MotoDetails/moto-details.component.html'    
})

export class MotoDetailsComponent implements OnInit {
    moto: Motocykl;
    message: string = 'Dane szczegółowe motocykla';

    constructor(private _activatedRoute: ActivatedRoute,
        private _motoService: MotoService,
        private _router: Router) { } 

    ngOnInit(): void {
        let id = +this._activatedRoute.snapshot.params['id'];
        this._motoService.get(id).subscribe(value => this.showMotoDetails(value), error => console.log(error));
    }

    private showMotoDetails(moto: Motocykl): void {
        this.moto = moto;

        if (this.moto === null) {
            this.message = `Motocykl o id "${this._activatedRoute.snapshot.params['id']}" nie istnieje.`;
        }
        else {
            this.message = 'Dane szczegółowe motocykla';
        }

    }

    private back(): void {
        this._router.navigate(['/motocykle']);
    }
}