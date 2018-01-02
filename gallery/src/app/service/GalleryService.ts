import {Injectable} from '@angular/core';

@Injectable()
export class GalleryService{
private _recentImages = []; 
    getImages(){
        return this._recentImages = IMAGES.slice(0);
    }
    getImage(imageID: number){
        return IMAGES.slice(0).find(image => image.Id == imageID);
    }
}


const IMAGES = [
    { "UserId": 1, "Id": 1, "Category": "Italy", "Description": "Coliseum", "Url": "assets/Images/1_Sam/123.jpg"   },
    { "UserId": 1, "Id": 2, "Category": "Food", "Description": "Tomato", "Url": "assets/Images/1_Sam/234.jpg"   },
    { "UserId": 1, "Id": 3, "Category": "Food", "Description": "Beef", "Url": "assets/Images/1_Sam/IMG_20150311_201335314_HDR.jpg"   },
    { "UserId": 1, "Id": 4, "Category": "Food", "Description": "Saffron cream soup with tuna", "Url": "assets/Images/1_Sam/IMG_20150311_202205553_HDR.jpg"   },
    { "UserId": 1, "Id": 5, "Category": "Food", "Description": "Ceviche", "Url": "assets/Images/1_Sam/IMG_20160228_175046709_HDR.jpg"   },
    { "UserId": 1, "Id": 6, "Category": "Food", "Description": "Dessert", "Url": "assets/Images/1_Sam/IMG_20160722_200626.jpg"   },
    { "UserId": 1, "Id": 7, "Category": "Scenary", "Description": "Club House", "Url": "assets/Images/1_Sam/IMG_20160722_203424.jpg"   },
    { "UserId": 1, "Id": 8, "Category": "Scenary", "Description": "Winery", "Url": "assets/Images/1_Sam/IMG_20160910_160408.jpg"   },
    { "UserId": 1, "Id": 9, "Category": "Food", "Description": "Scallops", "Url": "assets/Images/1_Sam/IMG_20161230_144045.jpg"   },
    { "UserId": 1, "Id": 10, "Category": "Food", "Description": "Tuna tartar", "Url": "assets/Images/1_Sam/IMG_20161230_144054.jpg"   },
    { "UserId": 1, "Id": 11, "Category": "Food", "Description": "homemade", "Url": "assets/Images/1_Sam/IMG_20170115_185904.jpg"   },
    { "UserId": 1, "Id": 12, "Category": "Food", "Description": "pizzzaa", "Url": "assets/Images/1_Sam/IMG_20170421_184240.jpg"   },
    { "UserId": 1, "Id": 13, "Category": "Italy", "Description": "Coliseum2", "Url": "assets/Images/1_Sam/IMG_20170425_200835.jpg"   },
    { "UserId": 1, "Id": 14, "Category": "Food", "Description": "Tomator Shrimp", "Url": "assets/Images/1_Sam/IMG_20170426_133032.jpg"   },
    { "UserId": 2, "Id": 15, "Category": "Italy", "Description": "Vatican", "Url": "assets/Images/2_Sarah/IMG_20170426_210935.jpg"   },
    { "UserId": 2, "Id": 16, "Category": "Italy", "Description": "Rome", "Url": "assets/Images/2_Sarah/IMG_20170427_140538.jpg"   },
    { "UserId": 2, "Id": 17, "Category": "Italy", "Description": "Leaving Italy!", "Url": "assets/Images/2_Sarah/IMG_20170428_200407.jpg"   },
    { "UserId": 2, "Id": 18, "Category": "Food", "Description": "Traditional Croatian food", "Url": "assets/Images/2_Sarah/IMG_20170430_194504.jpg"   },
    { "UserId": 2, "Id": 19, "Category": "Croatia", "Description": "Night Sky", "Url": "assets/Images/2_Sarah/IMG_20170430_205540.jpg"   },
    { "UserId": 2, "Id": 20, "Category": "Croatia", "Description": "Water", "Url": "assets/Images/2_Sarah/IMG_20170501_191454.jpg"   },
    { "UserId": 2, "Id": 21, "Category": "Croatia", "Description": "Split", "Url": "assets/Images/2_Sarah/IMG_20170502_215920.jpg"   },
    { "UserId": 2, "Id": 24, "Category": "Food", "Description": "Fish", "Url": "assets/Images/2_Sarah/IMG_20170503_194424.jpg"   },
    { "UserId": 2, "Id": 25, "Category": "DC", "Description": "Eclipse!", "Url": "assets/Images/2_Sarah/IMG_20170821_143543.jpg"   },
    { "UserId": 2, "Id": 26, "Category": "DC", "Description": "Monument", "Url": "assets/Images/2_Sarah/IMG_20171224_180352.jpg"   }
]