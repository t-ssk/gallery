import { Component, OnInit } from '@angular/core';
import { GalleryService } from '../service/GalleryService';
import { ActivatedRoute } from '@angular/router';

@Component({
    selector: 'app-image',
    templateUrl: './image.component.html',
    styleUrls: ['./image.component.css']
})
export class ImageComponent implements OnInit {
    image: any;

    constructor(private _galleryService: GalleryService, private route: ActivatedRoute) {
    }
    ngOnInit() {
        this.image = this._galleryService.getImage(
            +this.route.snapshot.params['Id']
        );
    }
}