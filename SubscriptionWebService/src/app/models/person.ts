class Person {
  id: number;
  givenName: string;
  familyName: string;
  email: string;
  phoneNumber: string;
  address: Address = new Address();
  invoice: InvoceData = new InvoceData();
  subscriptions: Subscription[] = [];
}
