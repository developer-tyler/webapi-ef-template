# Project Structure and Best Practices

This is a full-stack application with a .NET Web API backend and a React frontend. Follow these guidelines when working with the codebase.

## Backend (test-webapi)

### Project Structure
- `Controllers/`: REST API endpoints
- `Data/`: Database context and entity definitions
  - `AppDbContext.cs`: EF Core DB context
  - `Entities/`: Database entity models
- `DTOs/`: Data Transfer Objects for API responses
- `Services/`: Business logic layer
- `Repositories/`: Data access layer
- `Program.cs`: Application configuration and DI setup

### Best Practices
1. **Architecture**
   - Follow the Repository pattern
   - Use DTOs for API responses
   - Keep business logic in Services
   - Controllers should be thin and delegate to services

2. **Database**
   - Use Entity Framework Core for data access
   - Define relationships in AppDbContext.OnModelCreating
   - Use migrations for database schema changes
   - Configure cascade deletes appropriately

3. **API Design**
   - Use RESTful conventions
   - Return appropriate HTTP status codes
   - Validate input using DTOs
   - Use async/await for database operations

## Frontend (frontend)

### Project Structure
- `src/`
  - `components/`: React components
  - `contexts/`: React context providers
  - `services/`: API client services
- `public/`: Static assets
- `vite.config.js`: Vite configuration

### Best Practices
1. **React Development**
   - Use functional components with hooks
   - Keep components small and focused
   - Use TypeScript for type safety
   - Implement proper error handling

2. **State Management**
   - Use React Context for global state
   - Keep component state local when possible
   - Implement proper loading states

3. **API Integration**
   - Centralize API calls in service files
   - Handle errors gracefully
   - Show loading indicators during requests

## Development Workflow
1. Backend changes:
   - Add/modify entities in Data/Entities
   - Create/update DTOs
   - Implement repository methods
   - Add business logic in services
   - Create/update controller endpoints
   - Add migrations for schema changes

2. Frontend changes:
   - Add/update API service methods
   - Create/modify components
   - Update state management
   - Handle loading and error states

## Configuration
- Backend: Use appsettings.json for configuration
- Frontend: Use environment variables (.env files)
- Database: Connection string in appsettings.json
- CORS: Configured for localhost development

## Testing
- Use appropriate test files for components and services
- Follow the existing test patterns in the codebase
- Test both success and error scenarios