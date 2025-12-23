export interface Transaction {
    id?: number,
    description: string,
    value: number,
    type: number,
    categoryId: number,
    personId: number,
}