class Product {
  id: number;
  name: string;
  prince: number;
  upgradePrince: number;
  discount: Discount = new Discount();
}
