import { useEffect, useState } from 'react'
import type React from 'react'
import type { Transaction } from '../types/transaction';

interface Props {
  selectedTransaction?: Transaction | null;
  onSubmit: (person: Omit<Transaction, "id"> | Transaction) => void;
  onCancelEdit: () => void;
}

export function TransactionForm({ selectedTransaction, onSubmit }: Props) {
  const [description, setDescription] = useState("");
  const [value, setValue] = useState(0);
  const [type, setType] = useState(0);
  const [categoryId, setCategoryId] = useState(0);
  const [personId, setPersonId] = useState(0);

  useEffect(() => {
    async function initTransaction() {
      if (selectedTransaction) {
        setDescription(selectedTransaction.description);
        setValue(selectedTransaction.value);
        setType(selectedTransaction.type);
        setCategoryId(selectedTransaction.categoryId);
        setPersonId(selectedTransaction.personId);
      }
    }

    initTransaction();
  }, [selectedTransaction])

  async function handleSubmit(e: React.FormEvent) {
    e.preventDefault();

    onSubmit({ description, value, type, categoryId, personId });

    setDescription("");
    setValue(0);
    setType(0);
    setCategoryId(0);
    setPersonId(0);
  }

  return (
    <form onSubmit={handleSubmit}>
      <input
        type='text'
        name='description'
        placeholder='Short Description'
        value={description}
        onChange={e => setDescription(e.target.value)}
        required
      />

      <input
        type='number'
        name='value'
        placeholder='Value'
        value={value}
        onChange={e => setValue(Number(e.target.value))}
        required
      />

      <input
        type='number'
        name='type'
        placeholder='Type of the Transaction'
        value={type}
        onChange={e => setType(Number(e.target.value))}
        required
      />

      <input
        type='number'
        name='category'
        placeholder='Category'
        value={categoryId}
        onChange={e => setCategoryId(Number(e.target.value))}
        required
      />

      <input
        type='number'
        name='person'
        placeholder='Person'
        value={personId}
        onChange={e => setPersonId(Number(e.target.value))}
        required
      />

      <button type='submit'>
        Save
      </button>
    </form>
  )
}
