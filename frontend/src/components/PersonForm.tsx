import { useEffect, useState } from 'react'
import type React from 'react'
import type { Person } from '../types/person';
import Form from 'react-bootstrap/Form';
import { Button, Col, Row } from 'react-bootstrap';

interface Props {
  selectedPerson?: Person | null;
  onSubmit: (person: Omit<Person, "id"> | Person) => void;
  onCancelEdit: () => void;
}

export function PersonForm({ selectedPerson, onSubmit, onCancelEdit }: Props) {
  const [name, setName] = useState("");
  const [age, setAge] = useState(0);

  useEffect(() => {
    async function initPerson() {
      if (selectedPerson) {
        setName(selectedPerson.name);
        setAge(selectedPerson.age);
      }
    }

    initPerson();
  }, [selectedPerson])

  async function handleSubmit(e: React.FormEvent) {
    e.preventDefault();

    if (selectedPerson) {
      onSubmit({ id: selectedPerson.id, name, age } as any);
    } else {
      onSubmit({ name, age } as any);
    }

    setName("");
    setAge(0);
  }

  return (
    <Form onSubmit={handleSubmit} className='my-4'>
      <Form.Group as={Row}>
        <Form.Label column sm={2}>Name:</Form.Label>
        <Col sm={10}>
          <Form.Control
            type='text'
            name='name'
            placeholder='Name of Person'
            value={name}
            onChange={e => setName(e.target.value)}
            required
          />
        </Col>
      </Form.Group>

      <Form.Group as={Row}>
        <Form.Label column sm={2}>Age:</Form.Label>
        <Col sm={10}>
          <Form.Control
            type='number'
            name='age'
            placeholder='Age of Person'
            value={age}
            onChange={e => setAge(Number(e.target.value))}
            required
          />
        </Col>
      </Form.Group>

      <Form.Group as={Row} className="mb-3">
        <Button variant="primary" type="submit">
          {selectedPerson ? "Update" : "Save"}
        </Button>
        {selectedPerson && (
          <Button variant="secondary" onClick={onCancelEdit}>
            Cancel
          </Button>
        )}
      </Form.Group>
    </Form>
  )
}
