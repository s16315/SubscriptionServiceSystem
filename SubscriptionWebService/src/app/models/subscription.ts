class Subscription {
  id: number;
  product: Product = new Product();
  subscriptionStartTime: Date = new Date();
  subscriptionEndTime: Date = new Date();
  isPaid: boolean;
  demoAvailable: boolean;
  demoStartTime: Date = new Date();
  demoEndTime: Date = new Date();
}
