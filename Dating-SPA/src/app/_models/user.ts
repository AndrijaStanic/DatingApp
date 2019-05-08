import { Photo } from './photo';
//Entity User, uses class Photo
export interface User {
    id: number;
    username: string;
    knownAs: string;
    age: number;
    gener: string;
    created: Date;
    lastActive: Date;
    photoUrl: string;
    city: string;
    country: string;
    interests?: string;
    introduction?: string;
    lookingFor?: string;
    photos?: Photo[];
}
