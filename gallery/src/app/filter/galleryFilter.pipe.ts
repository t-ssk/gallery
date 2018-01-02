import {Pipe, PipeTransform} from '@angular/core'

@Pipe({name: 'galleryFilter'})
export class GalleryFilterPipe implements PipeTransform{
    transform(items: any[], criteria: string): any {
        if(criteria === 'All') 
        {
            return items;
        }
        else 
            return items.filter(item => {
                return item.Category === criteria;
            });
    }
}