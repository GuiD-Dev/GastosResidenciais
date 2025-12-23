import { BrowserRouter, Route, Routes } from "react-router-dom";
import { PersonPage } from "./pages/PersonPage";
import { CategoryPage } from "./pages/CategoryPage";
import { TransactionPage } from "./pages/TransactionPage";

export function AppRoutes() {
  return (
    <BrowserRouter>
      <Routes>
        <Route path="/person" Component={PersonPage} />
        <Route path="/category" Component={CategoryPage} />
        <Route path="/transaction" Component={TransactionPage} />
      </Routes>
    </BrowserRouter>
  );
}