import type { Transaction } from '../types/transaction';

interface Props {
  transactions: Transaction[];
  onDelete: (id: number) => void;
}

export function TransactionTable({ transactions, onDelete }: Props) {
  return (
    <table border={1} cellPadding={8}>
      <thead>
        <tr>
          <th>Description</th>
          <th>Value</th>
          <th>Type</th>
          <th>Category</th>
          <th>Person</th>
          <th>Actions</th>
        </tr>
      </thead>
      <tbody>
        {transactions.map(transaction => (
          <tr key={transaction.id}>
            <td>{transaction.description}</td>
            <td>{transaction.value}</td>
            <td>{transaction.type}</td>
            <td>{transaction.categoryId}</td>
            <td>{transaction.personId}</td>
            <td>
              <button onClick={() => onDelete(transaction.id!)}>Delete</button>
            </td>
          </tr>
        ))}
      </tbody>
    </table>
  )
}
