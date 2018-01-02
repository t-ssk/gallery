import { Component, OnChanges, Input } from '@angular/core';
import { GalleryService } from '../service/GalleryService';

@Component({
    selector: 'app-gallery',
    templateUrl: './gallery.component.html',
    styleUrls: ['./gallery.component.css']
})
export class GalleryComponent implements OnChanges {
    title = 'Your Gallery';
    visibleImages: any[] = [];

    buttonFilters: string[] = ['All'];
    @Input() filterBy?: string = 'All';


    constructor(private _galleryService: GalleryService) {
        this.visibleImages = this._galleryService.getImages();
        //this.buttonFilters = this.getButtonFilters(this.visibleImages);
        this.getButtonFilters(this.visibleImages);
    }
    ngOnChanges() {
        this.visibleImages = this._galleryService.getImages();
    }

    private getButtonFilters(items: any[]) {
        var uniqueCategory = items.map(item => item.Category);
        for (var category in uniqueCategory) {

            if (!this.buttonFilters.includes(uniqueCategory[category])) {
                this.buttonFilters.push(uniqueCategory[category]);
            }
        }
    }
}