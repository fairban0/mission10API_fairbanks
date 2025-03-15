import {
  useEffect,
  useState,
} from 'react';
import { bowler } from './types/bowler';

function BowlerList() {
  const [
    bowlers,
    setBowlers,
  ] = useState<bowler[]>([]);

  useEffect(() => {
    const fetchBowler =
      async () => {
        const response =
          await fetch(
            'https://localhost:5000/bowler'
          );
        const data =
          await response.json();
        setBowlers(data);
      };
    fetchBowler();
  }, []);

  return (
    <>
      <h1>Bowlers</h1>
      <table>
        <thead>
          <tr>
            <th>
              First Name
            </th>
            <th>
              Middle Inital
            </th>
            <th>Last Name</th>
            <th>Team Name</th>
            <th>Address</th>
            <th>City</th>
            <th>State</th>
            <th>Zip</th>
            <th>
              Phone Number
            </th>
          </tr>
        </thead>
        <tbody>
          {bowlers.map(
            (b) => [
              <tr
                key={
                  b.bowlerID
                }
              >
                <td>
                  {
                    b.firstName
                  }
                </td>
                <td>
                  {
                    b.middleInit
                  }
                </td>
                <td>
                  {b.lastName}
                </td>
                <td>
                  {b.teamName}
                </td>
                <td>
                  {b.address}
                </td>
                <td>
                  {b.city}
                </td>
                <td>
                  {b.state}
                </td>
                <td>
                  {b.zip}
                </td>
                <td>
                  {
                    b.phoneNumber
                  }
                </td>
              </tr>,
            ]
          )}
        </tbody>
      </table>
    </>
  );
}

export default BowlerList;
