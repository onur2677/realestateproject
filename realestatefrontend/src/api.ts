import axios from "axios";

type Image = {
    id: string;
    url: string;
    estateId: string;
}

export type Estate = {
    id: string;
    price: number;
    description: string;
    title: string;
    size: number;
    rooms: number;
    floor: number;
    year: number;
    images: Image[];
    district: {
        id: string;
        name: string;
        city: {
            id: string;
            name: string;
        };
        cityId: string;
    };
    districtId: string;
    estateType: {
        id: string;
        name: string;
    };
    estateTypeId: string;
}

export async function getEstates(query: string): Promise<Estate[]> {
    const response = await axios.get(`/api/estate${query ? `?${query}` : ''}`);
    const estates = response.data as Estate[];
    return estates;
}

